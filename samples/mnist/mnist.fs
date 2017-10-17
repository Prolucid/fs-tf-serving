module Samples

open FsTfServing
open FSharp.Data
open FSharpx
open System

module Mnist =
    let download () =
        //CVDF mirror of http://yann.lecun.com/exdb/mnist/
        let url = "https://storage.googleapis.com/cvdf-datasets/mnist/"
        // let train = "train-images-idx3-ubyte.gz"
        // let trainLabels = "train-labels-idx1-ubyte.gz"
        let test = "t10k-images-idx3-ubyte.gz"
        let testLabels = "t10k-labels-idx1-ubyte.gz"
        let downloads = [ // train
                          // trainLabels
                          test
                          testLabels ]
        downloads              
        |> List.filter (not << IO.File.Exists)
        |> List.map (fun name -> 
                        async { 
                            let! resp = Http.AsyncRequest (url+name)
                            let bytes = match resp.Body with
                                        | Binary bytes -> bytes
                                        | Text txt -> failwith txt
                            IO.File.WriteAllBytes(name,bytes)
                        })
        |> Async.Parallel
        |> Async.map (fun _ -> downloads)
        |> Async.RunSynchronously
        |> function [ixs;lxs] -> (ixs,lxs) | _ -> failwith "forgetting something?"

    let readInt32 (stream:IO.Stream) =
        let bytes = Array.zeroCreate<byte> 4
        stream.Read(bytes, 0, 4) |> ignore
        BitConverter.ToInt32 (bytes |> Array.rev, 0)

    let extractLabels name =
        use stream = new IO.Compression.GZipStream(IO.File.OpenRead name,IO.Compression.CompressionMode.Decompress)
        let magic = readInt32 stream
        if magic <> 2049 then failwithf "not a MNIST labels file, magic: %d" magic
        let numLabels = readInt32 stream
        let labels = Array.zeroCreate<byte> numLabels
        use reader = new IO.BinaryReader(stream)
        reader.ReadBytes numLabels

    let extractImages name =
        use stream = new IO.Compression.GZipStream(IO.File.OpenRead name,IO.Compression.CompressionMode.Decompress)
        let magic = readInt32 stream
        if magic <> 2051 then failwithf "not a MNIST image file, magic: %d" magic
        let numImages = readInt32 stream
        let rows = readInt32 stream
        let cols = readInt32 stream
        use reader = new IO.BinaryReader(stream)
        [| for _ in 1..numImages -> reader.ReadBytes(rows * cols) |]

    // let toOneHot labels numClasses =
    //     let len = labels |> Array.length
    //     let oneHot = Array2D.zeroCreate<byte> len numClasses
    //     for i in 0..len-1 do
    //         oneHot.[i, labels.[i]] <- 1uy
    //     oneHot

    let inline toFloats data =
        data |> Array.map (fun d -> (float32 d) / (float32 255))

    open MathNet.Numerics.LinearAlgebra
    let matchesLabel label (scores:#seq<_>) =
        let predicted = scores |> List.ofSeq |> vector |> Vector.maxIndex
        (int label) = predicted
        

open Tensorflow
open Tensorflow.Serving

let predict iter (srv:Clients.Prediction) =
    printf "Downloading test data...\n"
    let (test,testLabels) =
        Mnist.download()
        |> fun (ixs,lxs) -> Mnist.extractImages ixs, Mnist.extractLabels lxs

    printf "Classinfying...\n"
    let req = PredictRequest(ModelSpec = ModelSpec(Name = "mnist", SignatureName = "predict_images"))
    seq { 
        for i in 0..iter-1 do
            printf "."
            req.Inputs.["images"] <- 
                TensorProto(TensorShape = mkShape [1; test.[0].Length], Dtype = DataType.DtFloat)
                |> withValues (fun x -> x.FloatVal) (test.[i] |> Mnist.toFloats)
            let res = srv.Predict(req, deadline = Nullable(DateTime.UtcNow + TimeSpan.FromSeconds 5.))
            yield res.Outputs 
                    |> Seq.head
                    |> (function KeyValue("scores",scores) -> scores.FloatVal | x -> failwithf "%A" x) 
                    |> Mnist.matchesLabel testLabels.[i]
    } |> Seq.where id |> Seq.length

[<EntryPoint>]
let main argv =
    match argv with
    | [|iter;address;port|] -> 
        let n = (int iter)
        Connection.Insecure(address, (int port))
        |> Connection.create 
        |> predict n
        |> fun correct -> printf "\nInference error rate: %0.2f%%\n" (100. * float (n-correct) / (float n))
    | _ -> printf "Arguments:\nmnist ITERATIONS SERVER_ADDRESS SERVER_PORT"
    0 // return an integer exit code
