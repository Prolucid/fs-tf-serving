// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensor_bundle.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensor_bundle.proto</summary>
  public static partial class TensorBundleReflection {

    #region Descriptor
    /// <summary>File descriptor for tensor_bundle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TensorBundleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChN0ZW5zb3JfYnVuZGxlLnByb3RvEgp0ZW5zb3JmbG93Gix0ZW5zb3JmbG93",
            "L2NvcmUvZnJhbWV3b3JrL3RlbnNvcl9zaGFwZS5wcm90bxosdGVuc29yZmxv",
            "dy9jb3JlL2ZyYW1ld29yay90ZW5zb3Jfc2xpY2UucHJvdG8aJXRlbnNvcmZs",
            "b3cvY29yZS9mcmFtZXdvcmsvdHlwZXMucHJvdG8aKHRlbnNvcmZsb3cvY29y",
            "ZS9mcmFtZXdvcmsvdmVyc2lvbnMucHJvdG8isQEKEUJ1bmRsZUhlYWRlclBy",
            "b3RvEhIKCm51bV9zaGFyZHMYASABKAUSPAoKZW5kaWFubmVzcxgCIAEoDjIo",
            "LnRlbnNvcmZsb3cuQnVuZGxlSGVhZGVyUHJvdG8uRW5kaWFubmVzcxInCgd2",
            "ZXJzaW9uGAMgASgLMhYudGVuc29yZmxvdy5WZXJzaW9uRGVmIiEKCkVuZGlh",
            "bm5lc3MSCgoGTElUVExFEAASBwoDQklHEAEi0gEKEEJ1bmRsZUVudHJ5UHJv",
            "dG8SIwoFZHR5cGUYASABKA4yFC50ZW5zb3JmbG93LkRhdGFUeXBlEisKBXNo",
            "YXBlGAIgASgLMhwudGVuc29yZmxvdy5UZW5zb3JTaGFwZVByb3RvEhAKCHNo",
            "YXJkX2lkGAMgASgFEg4KBm9mZnNldBgEIAEoAxIMCgRzaXplGAUgASgDEg4K",
            "BmNyYzMyYxgGIAEoBxIsCgZzbGljZXMYByADKAsyHC50ZW5zb3JmbG93LlRl",
            "bnNvclNsaWNlUHJvdG9CLgoTb3JnLnRlbnNvcmZsb3cudXRpbEISVGVuc29y",
            "QnVuZGxlUHJvdG9zUAH4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.TensorShapeReflection.Descriptor, global::Tensorflow.TensorSliceReflection.Descriptor, global::Tensorflow.TypesReflection.Descriptor, global::Tensorflow.VersionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.BundleHeaderProto), global::Tensorflow.BundleHeaderProto.Parser, new[]{ "NumShards", "Endianness", "Version" }, null, new[]{ typeof(global::Tensorflow.BundleHeaderProto.Types.Endianness) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.BundleEntryProto), global::Tensorflow.BundleEntryProto.Parser, new[]{ "Dtype", "Shape", "ShardId", "Offset", "Size", "Crc32C", "Slices" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Special header that is associated with a bundle.
  ///
  /// TODO(zongheng,zhifengc): maybe in the future, we can add information about
  /// which binary produced this checkpoint, timestamp, etc. Sometime, these can be
  /// valuable debugging information. And if needed, these can be used as defensive
  /// information ensuring reader (binary version) of the checkpoint and the writer
  /// (binary version) must match within certain range, etc.
  /// </summary>
  public sealed partial class BundleHeaderProto : pb::IMessage<BundleHeaderProto> {
    private static readonly pb::MessageParser<BundleHeaderProto> _parser = new pb::MessageParser<BundleHeaderProto>(() => new BundleHeaderProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BundleHeaderProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.TensorBundleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BundleHeaderProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BundleHeaderProto(BundleHeaderProto other) : this() {
      numShards_ = other.numShards_;
      endianness_ = other.endianness_;
      Version = other.version_ != null ? other.Version.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BundleHeaderProto Clone() {
      return new BundleHeaderProto(this);
    }

    /// <summary>Field number for the "num_shards" field.</summary>
    public const int NumShardsFieldNumber = 1;
    private int numShards_;
    /// <summary>
    /// Number of data files in the bundle.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumShards {
      get { return numShards_; }
      set {
        numShards_ = value;
      }
    }

    /// <summary>Field number for the "endianness" field.</summary>
    public const int EndiannessFieldNumber = 2;
    private global::Tensorflow.BundleHeaderProto.Types.Endianness endianness_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.BundleHeaderProto.Types.Endianness Endianness {
      get { return endianness_; }
      set {
        endianness_ = value;
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 3;
    private global::Tensorflow.VersionDef version_;
    /// <summary>
    /// Versioning of the tensor bundle format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.VersionDef Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BundleHeaderProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BundleHeaderProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NumShards != other.NumShards) return false;
      if (Endianness != other.Endianness) return false;
      if (!object.Equals(Version, other.Version)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NumShards != 0) hash ^= NumShards.GetHashCode();
      if (Endianness != 0) hash ^= Endianness.GetHashCode();
      if (version_ != null) hash ^= Version.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (NumShards != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(NumShards);
      }
      if (Endianness != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Endianness);
      }
      if (version_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Version);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NumShards != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumShards);
      }
      if (Endianness != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Endianness);
      }
      if (version_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Version);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BundleHeaderProto other) {
      if (other == null) {
        return;
      }
      if (other.NumShards != 0) {
        NumShards = other.NumShards;
      }
      if (other.Endianness != 0) {
        Endianness = other.Endianness;
      }
      if (other.version_ != null) {
        if (version_ == null) {
          version_ = new global::Tensorflow.VersionDef();
        }
        Version.MergeFrom(other.Version);
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
            NumShards = input.ReadInt32();
            break;
          }
          case 16: {
            endianness_ = (global::Tensorflow.BundleHeaderProto.Types.Endianness) input.ReadEnum();
            break;
          }
          case 26: {
            if (version_ == null) {
              version_ = new global::Tensorflow.VersionDef();
            }
            input.ReadMessage(version_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BundleHeaderProto message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// An enum indicating the endianness of the platform that produced this
      /// bundle.  A bundle can only be read by a platform with matching endianness.
      /// Defaults to LITTLE, as most modern platforms are little-endian.
      ///
      /// Affects the binary tensor data bytes only, not the metadata in protobufs.
      /// </summary>
      public enum Endianness {
        [pbr::OriginalName("LITTLE")] Little = 0,
        [pbr::OriginalName("BIG")] Big = 1,
      }

    }
    #endregion

  }

  /// <summary>
  /// Describes the metadata related to a checkpointed tensor.
  /// </summary>
  public sealed partial class BundleEntryProto : pb::IMessage<BundleEntryProto> {
    private static readonly pb::MessageParser<BundleEntryProto> _parser = new pb::MessageParser<BundleEntryProto>(() => new BundleEntryProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BundleEntryProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.TensorBundleReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BundleEntryProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BundleEntryProto(BundleEntryProto other) : this() {
      dtype_ = other.dtype_;
      Shape = other.shape_ != null ? other.Shape.Clone() : null;
      shardId_ = other.shardId_;
      offset_ = other.offset_;
      size_ = other.size_;
      crc32C_ = other.crc32C_;
      slices_ = other.slices_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BundleEntryProto Clone() {
      return new BundleEntryProto(this);
    }

    /// <summary>Field number for the "dtype" field.</summary>
    public const int DtypeFieldNumber = 1;
    private global::Tensorflow.DataType dtype_ = 0;
    /// <summary>
    /// The tensor dtype and shape.
    /// </summary>
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

    /// <summary>Field number for the "shard_id" field.</summary>
    public const int ShardIdFieldNumber = 3;
    private int shardId_;
    /// <summary>
    /// The binary content of the tensor lies in:
    ///   File "shard_id": bytes [offset, offset + size).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ShardId {
      get { return shardId_; }
      set {
        shardId_ = value;
      }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 4;
    private long offset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 5;
    private long size_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "crc32c" field.</summary>
    public const int Crc32CFieldNumber = 6;
    private uint crc32C_;
    /// <summary>
    /// The CRC32C checksum of the tensor bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Crc32C {
      get { return crc32C_; }
      set {
        crc32C_ = value;
      }
    }

    /// <summary>Field number for the "slices" field.</summary>
    public const int SlicesFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Tensorflow.TensorSliceProto> _repeated_slices_codec
        = pb::FieldCodec.ForMessage(58, global::Tensorflow.TensorSliceProto.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.TensorSliceProto> slices_ = new pbc::RepeatedField<global::Tensorflow.TensorSliceProto>();
    /// <summary>
    /// Iff present, this entry represents a partitioned tensor.  The previous
    /// fields are interpreted as follows:
    ///
    ///   "dtype", "shape": describe the full tensor.
    ///   "shard_id", "offset", "size", "crc32c": all IGNORED.
    ///      These information for each slice can be looked up in their own
    ///      BundleEntryProto, keyed by each "slice_name".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.TensorSliceProto> Slices {
      get { return slices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BundleEntryProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BundleEntryProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Dtype != other.Dtype) return false;
      if (!object.Equals(Shape, other.Shape)) return false;
      if (ShardId != other.ShardId) return false;
      if (Offset != other.Offset) return false;
      if (Size != other.Size) return false;
      if (Crc32C != other.Crc32C) return false;
      if(!slices_.Equals(other.slices_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Dtype != 0) hash ^= Dtype.GetHashCode();
      if (shape_ != null) hash ^= Shape.GetHashCode();
      if (ShardId != 0) hash ^= ShardId.GetHashCode();
      if (Offset != 0L) hash ^= Offset.GetHashCode();
      if (Size != 0L) hash ^= Size.GetHashCode();
      if (Crc32C != 0) hash ^= Crc32C.GetHashCode();
      hash ^= slices_.GetHashCode();
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
      if (ShardId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ShardId);
      }
      if (Offset != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Offset);
      }
      if (Size != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(Size);
      }
      if (Crc32C != 0) {
        output.WriteRawTag(53);
        output.WriteFixed32(Crc32C);
      }
      slices_.WriteTo(output, _repeated_slices_codec);
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
      if (ShardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ShardId);
      }
      if (Offset != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Offset);
      }
      if (Size != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Size);
      }
      if (Crc32C != 0) {
        size += 1 + 4;
      }
      size += slices_.CalculateSize(_repeated_slices_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BundleEntryProto other) {
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
      if (other.ShardId != 0) {
        ShardId = other.ShardId;
      }
      if (other.Offset != 0L) {
        Offset = other.Offset;
      }
      if (other.Size != 0L) {
        Size = other.Size;
      }
      if (other.Crc32C != 0) {
        Crc32C = other.Crc32C;
      }
      slices_.Add(other.slices_);
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
          case 24: {
            ShardId = input.ReadInt32();
            break;
          }
          case 32: {
            Offset = input.ReadInt64();
            break;
          }
          case 40: {
            Size = input.ReadInt64();
            break;
          }
          case 53: {
            Crc32C = input.ReadFixed32();
            break;
          }
          case 58: {
            slices_.AddEntriesFrom(input, _repeated_slices_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code