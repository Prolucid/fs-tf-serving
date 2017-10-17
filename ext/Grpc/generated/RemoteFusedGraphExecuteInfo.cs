// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: remote_fused_graph_execute_info.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from remote_fused_graph_execute_info.proto</summary>
  public static partial class RemoteFusedGraphExecuteInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for remote_fused_graph_execute_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RemoteFusedGraphExecuteInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVyZW1vdGVfZnVzZWRfZ3JhcGhfZXhlY3V0ZV9pbmZvLnByb3RvEgp0ZW5z",
            "b3JmbG93GiV0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL2dyYXBoLnByb3Rv",
            "Gix0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL3RlbnNvcl9zaGFwZS5wcm90",
            "bxoldGVuc29yZmxvdy9jb3JlL2ZyYW1ld29yay90eXBlcy5wcm90byLyBAob",
            "UmVtb3RlRnVzZWRHcmFwaEV4ZWN1dGVJbmZvEioKDHJlbW90ZV9ncmFwaBgB",
            "IAEoCzIULnRlbnNvcmZsb3cuR3JhcGhEZWYSHQoVZ3JhcGhfaW5wdXRfbm9k",
            "ZV9uYW1lGAIgAygJEh4KFmdyYXBoX291dHB1dF9ub2RlX25hbWUYAyADKAkS",
            "FQoNZXhlY3V0b3JfbmFtZRgEIAEoCRImCh5zZXJpYWxpemVkX2V4ZWN1dG9y",
            "X3BhcmFtZXRlcnMYBSABKAwSZgogZGVmYXVsdF9ncmFwaF9pbnB1dF90ZW5z",
            "b3Jfc2hhcGUYBiADKAsyPC50ZW5zb3JmbG93LlJlbW90ZUZ1c2VkR3JhcGhF",
            "eGVjdXRlSW5mby5UZW5zb3JTaGFwZVR5cGVQcm90bxJnCiFkZWZhdWx0X2dy",
            "YXBoX291dHB1dF90ZW5zb3Jfc2hhcGUYByADKAsyPC50ZW5zb3JmbG93LlJl",
            "bW90ZUZ1c2VkR3JhcGhFeGVjdXRlSW5mby5UZW5zb3JTaGFwZVR5cGVQcm90",
            "bxpoChRUZW5zb3JTaGFwZVR5cGVQcm90bxIjCgVkdHlwZRgBIAEoDjIULnRl",
            "bnNvcmZsb3cuRGF0YVR5cGUSKwoFc2hhcGUYAiABKAsyHC50ZW5zb3JmbG93",
            "LlRlbnNvclNoYXBlUHJvdG8ibgoITm9kZVR5cGUSCgoGVU5VU0VEEAASDwoL",
            "R1JBUEhfSU5QVVQQARIQCgxHUkFQSF9PVVRQVVQQAhIOCgpGVVNFRF9OT0RF",
            "EAMSEAoMQk9SREVSX0lOUFVUEAQSEQoNQk9SREVSX09VVFBVVBAFQkEKGG9y",
            "Zy50ZW5zb3JmbG93LmZyYW1ld29ya0IgUmVtb3RlRnVzZWRHcmFwaEV4ZWN1",
            "dGVJbmZvUHJvdG9QAfgBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.GraphReflection.Descriptor, global::Tensorflow.TensorShapeReflection.Descriptor, global::Tensorflow.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.RemoteFusedGraphExecuteInfo), global::Tensorflow.RemoteFusedGraphExecuteInfo.Parser, new[]{ "RemoteGraph", "GraphInputNodeName", "GraphOutputNodeName", "ExecutorName", "SerializedExecutorParameters", "DefaultGraphInputTensorShape", "DefaultGraphOutputTensorShape" }, null, new[]{ typeof(global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.NodeType) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto), global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto.Parser, new[]{ "Dtype", "Shape" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Protocol buffer representing a handle to a tensorflow resource. Handles are
  /// not valid across executions, but can be serialized back and forth from within
  /// a single run.
  /// </summary>
  public sealed partial class RemoteFusedGraphExecuteInfo : pb::IMessage<RemoteFusedGraphExecuteInfo> {
    private static readonly pb::MessageParser<RemoteFusedGraphExecuteInfo> _parser = new pb::MessageParser<RemoteFusedGraphExecuteInfo>(() => new RemoteFusedGraphExecuteInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RemoteFusedGraphExecuteInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.RemoteFusedGraphExecuteInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoteFusedGraphExecuteInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoteFusedGraphExecuteInfo(RemoteFusedGraphExecuteInfo other) : this() {
      RemoteGraph = other.remoteGraph_ != null ? other.RemoteGraph.Clone() : null;
      graphInputNodeName_ = other.graphInputNodeName_.Clone();
      graphOutputNodeName_ = other.graphOutputNodeName_.Clone();
      executorName_ = other.executorName_;
      serializedExecutorParameters_ = other.serializedExecutorParameters_;
      defaultGraphInputTensorShape_ = other.defaultGraphInputTensorShape_.Clone();
      defaultGraphOutputTensorShape_ = other.defaultGraphOutputTensorShape_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoteFusedGraphExecuteInfo Clone() {
      return new RemoteFusedGraphExecuteInfo(this);
    }

    /// <summary>Field number for the "remote_graph" field.</summary>
    public const int RemoteGraphFieldNumber = 1;
    private global::Tensorflow.GraphDef remoteGraph_;
    /// <summary>
    /// Definition of remote graph
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.GraphDef RemoteGraph {
      get { return remoteGraph_; }
      set {
        remoteGraph_ = value;
      }
    }

    /// <summary>Field number for the "graph_input_node_name" field.</summary>
    public const int GraphInputNodeNameFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_graphInputNodeName_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> graphInputNodeName_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Remote fused graph input node name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> GraphInputNodeName {
      get { return graphInputNodeName_; }
    }

    /// <summary>Field number for the "graph_output_node_name" field.</summary>
    public const int GraphOutputNodeNameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_graphOutputNodeName_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> graphOutputNodeName_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Remote fused graph output node name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> GraphOutputNodeName {
      get { return graphOutputNodeName_; }
    }

    /// <summary>Field number for the "executor_name" field.</summary>
    public const int ExecutorNameFieldNumber = 4;
    private string executorName_ = "";
    /// <summary>
    /// Executor's name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExecutorName {
      get { return executorName_; }
      set {
        executorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "serialized_executor_parameters" field.</summary>
    public const int SerializedExecutorParametersFieldNumber = 5;
    private pb::ByteString serializedExecutorParameters_ = pb::ByteString.Empty;
    /// <summary>
    /// Optional: Parameters given to the executor
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString SerializedExecutorParameters {
      get { return serializedExecutorParameters_; }
      set {
        serializedExecutorParameters_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "default_graph_input_tensor_shape" field.</summary>
    public const int DefaultGraphInputTensorShapeFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto> _repeated_defaultGraphInputTensorShape_codec
        = pb::FieldCodec.ForMessage(50, global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto> defaultGraphInputTensorShape_ = new pbc::RepeatedField<global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto>();
    /// <summary>
    /// Optional: Default graph input tensor shape used to allocate memory
    /// before executing op
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto> DefaultGraphInputTensorShape {
      get { return defaultGraphInputTensorShape_; }
    }

    /// <summary>Field number for the "default_graph_output_tensor_shape" field.</summary>
    public const int DefaultGraphOutputTensorShapeFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto> _repeated_defaultGraphOutputTensorShape_codec
        = pb::FieldCodec.ForMessage(58, global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto> defaultGraphOutputTensorShape_ = new pbc::RepeatedField<global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto>();
    /// <summary>
    /// Optional: Default graph input tensor shape used to allocate memory
    /// before executing op
    /// TODO(satok): Remote output tensor shape once shape information is stored
    /// in NodeDef
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.RemoteFusedGraphExecuteInfo.Types.TensorShapeTypeProto> DefaultGraphOutputTensorShape {
      get { return defaultGraphOutputTensorShape_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RemoteFusedGraphExecuteInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RemoteFusedGraphExecuteInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RemoteGraph, other.RemoteGraph)) return false;
      if(!graphInputNodeName_.Equals(other.graphInputNodeName_)) return false;
      if(!graphOutputNodeName_.Equals(other.graphOutputNodeName_)) return false;
      if (ExecutorName != other.ExecutorName) return false;
      if (SerializedExecutorParameters != other.SerializedExecutorParameters) return false;
      if(!defaultGraphInputTensorShape_.Equals(other.defaultGraphInputTensorShape_)) return false;
      if(!defaultGraphOutputTensorShape_.Equals(other.defaultGraphOutputTensorShape_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (remoteGraph_ != null) hash ^= RemoteGraph.GetHashCode();
      hash ^= graphInputNodeName_.GetHashCode();
      hash ^= graphOutputNodeName_.GetHashCode();
      if (ExecutorName.Length != 0) hash ^= ExecutorName.GetHashCode();
      if (SerializedExecutorParameters.Length != 0) hash ^= SerializedExecutorParameters.GetHashCode();
      hash ^= defaultGraphInputTensorShape_.GetHashCode();
      hash ^= defaultGraphOutputTensorShape_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (remoteGraph_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RemoteGraph);
      }
      graphInputNodeName_.WriteTo(output, _repeated_graphInputNodeName_codec);
      graphOutputNodeName_.WriteTo(output, _repeated_graphOutputNodeName_codec);
      if (ExecutorName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ExecutorName);
      }
      if (SerializedExecutorParameters.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(SerializedExecutorParameters);
      }
      defaultGraphInputTensorShape_.WriteTo(output, _repeated_defaultGraphInputTensorShape_codec);
      defaultGraphOutputTensorShape_.WriteTo(output, _repeated_defaultGraphOutputTensorShape_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (remoteGraph_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RemoteGraph);
      }
      size += graphInputNodeName_.CalculateSize(_repeated_graphInputNodeName_codec);
      size += graphOutputNodeName_.CalculateSize(_repeated_graphOutputNodeName_codec);
      if (ExecutorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExecutorName);
      }
      if (SerializedExecutorParameters.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SerializedExecutorParameters);
      }
      size += defaultGraphInputTensorShape_.CalculateSize(_repeated_defaultGraphInputTensorShape_codec);
      size += defaultGraphOutputTensorShape_.CalculateSize(_repeated_defaultGraphOutputTensorShape_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RemoteFusedGraphExecuteInfo other) {
      if (other == null) {
        return;
      }
      if (other.remoteGraph_ != null) {
        if (remoteGraph_ == null) {
          remoteGraph_ = new global::Tensorflow.GraphDef();
        }
        RemoteGraph.MergeFrom(other.RemoteGraph);
      }
      graphInputNodeName_.Add(other.graphInputNodeName_);
      graphOutputNodeName_.Add(other.graphOutputNodeName_);
      if (other.ExecutorName.Length != 0) {
        ExecutorName = other.ExecutorName;
      }
      if (other.SerializedExecutorParameters.Length != 0) {
        SerializedExecutorParameters = other.SerializedExecutorParameters;
      }
      defaultGraphInputTensorShape_.Add(other.defaultGraphInputTensorShape_);
      defaultGraphOutputTensorShape_.Add(other.defaultGraphOutputTensorShape_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (remoteGraph_ == null) {
              remoteGraph_ = new global::Tensorflow.GraphDef();
            }
            input.ReadMessage(remoteGraph_);
            break;
          }
          case 18: {
            graphInputNodeName_.AddEntriesFrom(input, _repeated_graphInputNodeName_codec);
            break;
          }
          case 26: {
            graphOutputNodeName_.AddEntriesFrom(input, _repeated_graphOutputNodeName_codec);
            break;
          }
          case 34: {
            ExecutorName = input.ReadString();
            break;
          }
          case 42: {
            SerializedExecutorParameters = input.ReadBytes();
            break;
          }
          case 50: {
            defaultGraphInputTensorShape_.AddEntriesFrom(input, _repeated_defaultGraphInputTensorShape_codec);
            break;
          }
          case 58: {
            defaultGraphOutputTensorShape_.AddEntriesFrom(input, _repeated_defaultGraphOutputTensorShape_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RemoteFusedGraphExecuteInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum NodeType {
        [pbr::OriginalName("UNUSED")] Unused = 0,
        [pbr::OriginalName("GRAPH_INPUT")] GraphInput = 1,
        [pbr::OriginalName("GRAPH_OUTPUT")] GraphOutput = 2,
        [pbr::OriginalName("FUSED_NODE")] FusedNode = 3,
        [pbr::OriginalName("BORDER_INPUT")] BorderInput = 4,
        [pbr::OriginalName("BORDER_OUTPUT")] BorderOutput = 5,
      }

      public sealed partial class TensorShapeTypeProto : pb::IMessage<TensorShapeTypeProto> {
        private static readonly pb::MessageParser<TensorShapeTypeProto> _parser = new pb::MessageParser<TensorShapeTypeProto>(() => new TensorShapeTypeProto());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<TensorShapeTypeProto> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Tensorflow.RemoteFusedGraphExecuteInfo.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TensorShapeTypeProto() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TensorShapeTypeProto(TensorShapeTypeProto other) : this() {
          dtype_ = other.dtype_;
          Shape = other.shape_ != null ? other.Shape.Clone() : null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TensorShapeTypeProto Clone() {
          return new TensorShapeTypeProto(this);
        }

        /// <summary>Field number for the "dtype" field.</summary>
        public const int DtypeFieldNumber = 1;
        private global::Tensorflow.DataType dtype_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Tensorflow.DataType Dtype {
          get { return dtype_; }
          set {
            dtype_ = value;
          }
        }

        /// <summary>Field number for the "shape" field.</summary>
        public const int ShapeFieldNumber = 2;
        private global::Tensorflow.TensorShapeProto shape_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Tensorflow.TensorShapeProto Shape {
          get { return shape_; }
          set {
            shape_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as TensorShapeTypeProto);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(TensorShapeTypeProto other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Dtype != other.Dtype) return false;
          if (!object.Equals(Shape, other.Shape)) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Dtype != 0) hash ^= Dtype.GetHashCode();
          if (shape_ != null) hash ^= Shape.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Dtype != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Dtype);
          }
          if (shape_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(Shape);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Dtype != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Dtype);
          }
          if (shape_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Shape);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(TensorShapeTypeProto other) {
          if (other == null) {
            return;
          }
          if (other.Dtype != 0) {
            Dtype = other.Dtype;
          }
          if (other.shape_ != null) {
            if (shape_ == null) {
              shape_ = new global::Tensorflow.TensorShapeProto();
            }
            Shape.MergeFrom(other.Shape);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 8: {
                dtype_ = (global::Tensorflow.DataType) input.ReadEnum();
                break;
              }
              case 18: {
                if (shape_ == null) {
                  shape_ = new global::Tensorflow.TensorShapeProto();
                }
                input.ReadMessage(shape_);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
