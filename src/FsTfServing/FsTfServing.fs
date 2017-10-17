namespace FsTfServing

module Clients =
    type Prediction = Tensorflow.Serving.PredictionService.PredictionServiceClient

module Connection =
    open Tensorflow.Serving
    open Grpc.Core

    type Options = 
        | Insecure of address : string * port : int
        | Ssl of address : string * port : int

    let create options =
        let channel = match options with
                      | Insecure (address,port) -> Channel(address, port, ChannelCredentials.Insecure)
                      | Ssl (address,port) -> Channel(address, port, SslCredentials())
        Tensorflow.Serving.PredictionService.PredictionServiceClient(channel)

[<AutoOpen>]
module Dsl =
    open Tensorflow
    open System
    
    let inline mkShape (dims:#seq<_>) = 
        let shape = TensorShapeProto()
        dims |> Seq.iter (fun s -> shape.Dim.Add(TensorShapeProto.Types.Dim(Size = (int64 s))))
        shape
    
    let inline withValues (getMember:_->#Collections.Generic.ICollection<_>) (xs:#seq<_>) x =
        let mem = getMember x
        xs |> Seq.iter mem.Add
        x