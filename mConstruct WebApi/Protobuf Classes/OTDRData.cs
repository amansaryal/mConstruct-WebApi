// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/OTDRData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.services {

  /// <summary>Holder for reflection information generated from protos/OTDRData.proto</summary>
  public static partial class OTDRDataReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/OTDRData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OTDRDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVwcm90b3MvT1REUkRhdGEucHJvdG8iygIKCE9URFJEYXRhEhAKCG9iamVj",
            "dElEGAEgASgDEg4KBnRhc2tJRBgCIAEoCRIgCgZzdGF0dXMYAyABKA4yEC5P",
            "VERSRGF0YS5TdGF0dXMSJgoJZGlyZWN0aW9uGAQgASgOMhMuT1REUkRhdGEu",
            "RGlyZWN0aW9uEgwKBHBvcnQYBSABKAUSEAoIbGlua0xvc3MYBiABKAESDgoG",
            "bGVuZ3RoGAcgASgBEg0KBWV2ZW50GAggASgFEhEKCW1heFNwbGljZRgJIAEo",
            "ARIPCgdsaW5rT1JMGAogASgBEgwKBGZpbGUYCyADKAkSEAoIZmlsZXR5cGUY",
            "DCADKAkiJAoGU3RhdHVzEgsKB09OX0hPTEQQABINCglDT01QTEVURUQQASIp",
            "CglEaXJlY3Rpb24SCAoETk9ORRAAEggKBEVBU1QQARIICgRXRVNUEAJCKQoX",
            "Y29tLm1Db25zdHJ1Y3QucHJvdG9idWaqAg1HcnBjLnNlcnZpY2VzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.services.OTDRData), global::Grpc.services.OTDRData.Parser, new[]{ "ObjectID", "TaskID", "Status", "Direction", "Port", "LinkLoss", "Length", "Event", "MaxSplice", "LinkORL", "File", "Filetype" }, null, new[]{ typeof(global::Grpc.services.OTDRData.Types.Status), typeof(global::Grpc.services.OTDRData.Types.Direction) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OTDRData : pb::IMessage<OTDRData> {
    private static readonly pb::MessageParser<OTDRData> _parser = new pb::MessageParser<OTDRData>(() => new OTDRData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OTDRData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.services.OTDRDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTDRData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTDRData(OTDRData other) : this() {
      objectID_ = other.objectID_;
      taskID_ = other.taskID_;
      status_ = other.status_;
      direction_ = other.direction_;
      port_ = other.port_;
      linkLoss_ = other.linkLoss_;
      length_ = other.length_;
      event_ = other.event_;
      maxSplice_ = other.maxSplice_;
      linkORL_ = other.linkORL_;
      file_ = other.file_.Clone();
      filetype_ = other.filetype_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTDRData Clone() {
      return new OTDRData(this);
    }

    /// <summary>Field number for the "objectID" field.</summary>
    public const int ObjectIDFieldNumber = 1;
    private long objectID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ObjectID {
      get { return objectID_; }
      set {
        objectID_ = value;
      }
    }

    /// <summary>Field number for the "taskID" field.</summary>
    public const int TaskIDFieldNumber = 2;
    private string taskID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TaskID {
      get { return taskID_; }
      set {
        taskID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Grpc.services.OTDRData.Types.Status status_ = global::Grpc.services.OTDRData.Types.Status.OnHold;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.services.OTDRData.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "direction" field.</summary>
    public const int DirectionFieldNumber = 4;
    private global::Grpc.services.OTDRData.Types.Direction direction_ = global::Grpc.services.OTDRData.Types.Direction.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.services.OTDRData.Types.Direction Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 5;
    private int port_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    /// <summary>Field number for the "linkLoss" field.</summary>
    public const int LinkLossFieldNumber = 6;
    private double linkLoss_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LinkLoss {
      get { return linkLoss_; }
      set {
        linkLoss_ = value;
      }
    }

    /// <summary>Field number for the "length" field.</summary>
    public const int LengthFieldNumber = 7;
    private double length_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Length {
      get { return length_; }
      set {
        length_ = value;
      }
    }

    /// <summary>Field number for the "event" field.</summary>
    public const int EventFieldNumber = 8;
    private int event_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Event {
      get { return event_; }
      set {
        event_ = value;
      }
    }

    /// <summary>Field number for the "maxSplice" field.</summary>
    public const int MaxSpliceFieldNumber = 9;
    private double maxSplice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MaxSplice {
      get { return maxSplice_; }
      set {
        maxSplice_ = value;
      }
    }

    /// <summary>Field number for the "linkORL" field.</summary>
    public const int LinkORLFieldNumber = 10;
    private double linkORL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LinkORL {
      get { return linkORL_; }
      set {
        linkORL_ = value;
      }
    }

    /// <summary>Field number for the "file" field.</summary>
    public const int FileFieldNumber = 11;
    private static readonly pb::FieldCodec<string> _repeated_file_codec
        = pb::FieldCodec.ForString(90);
    private readonly pbc::RepeatedField<string> file_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> File {
      get { return file_; }
    }

    /// <summary>Field number for the "filetype" field.</summary>
    public const int FiletypeFieldNumber = 12;
    private static readonly pb::FieldCodec<string> _repeated_filetype_codec
        = pb::FieldCodec.ForString(98);
    private readonly pbc::RepeatedField<string> filetype_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Filetype {
      get { return filetype_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OTDRData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OTDRData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ObjectID != other.ObjectID) return false;
      if (TaskID != other.TaskID) return false;
      if (Status != other.Status) return false;
      if (Direction != other.Direction) return false;
      if (Port != other.Port) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LinkLoss, other.LinkLoss)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Length, other.Length)) return false;
      if (Event != other.Event) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxSplice, other.MaxSplice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LinkORL, other.LinkORL)) return false;
      if(!file_.Equals(other.file_)) return false;
      if(!filetype_.Equals(other.filetype_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ObjectID != 0L) hash ^= ObjectID.GetHashCode();
      if (TaskID.Length != 0) hash ^= TaskID.GetHashCode();
      if (Status != global::Grpc.services.OTDRData.Types.Status.OnHold) hash ^= Status.GetHashCode();
      if (Direction != global::Grpc.services.OTDRData.Types.Direction.None) hash ^= Direction.GetHashCode();
      if (Port != 0) hash ^= Port.GetHashCode();
      if (LinkLoss != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LinkLoss);
      if (Length != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Length);
      if (Event != 0) hash ^= Event.GetHashCode();
      if (MaxSplice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxSplice);
      if (LinkORL != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LinkORL);
      hash ^= file_.GetHashCode();
      hash ^= filetype_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ObjectID != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ObjectID);
      }
      if (TaskID.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TaskID);
      }
      if (Status != global::Grpc.services.OTDRData.Types.Status.OnHold) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Direction != global::Grpc.services.OTDRData.Types.Direction.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Direction);
      }
      if (Port != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Port);
      }
      if (LinkLoss != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(LinkLoss);
      }
      if (Length != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Length);
      }
      if (Event != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Event);
      }
      if (MaxSplice != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(MaxSplice);
      }
      if (LinkORL != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(LinkORL);
      }
      file_.WriteTo(output, _repeated_file_codec);
      filetype_.WriteTo(output, _repeated_filetype_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ObjectID != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ObjectID);
      }
      if (TaskID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TaskID);
      }
      if (Status != global::Grpc.services.OTDRData.Types.Status.OnHold) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Direction != global::Grpc.services.OTDRData.Types.Direction.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Direction);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Port);
      }
      if (LinkLoss != 0D) {
        size += 1 + 8;
      }
      if (Length != 0D) {
        size += 1 + 8;
      }
      if (Event != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Event);
      }
      if (MaxSplice != 0D) {
        size += 1 + 8;
      }
      if (LinkORL != 0D) {
        size += 1 + 8;
      }
      size += file_.CalculateSize(_repeated_file_codec);
      size += filetype_.CalculateSize(_repeated_filetype_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OTDRData other) {
      if (other == null) {
        return;
      }
      if (other.ObjectID != 0L) {
        ObjectID = other.ObjectID;
      }
      if (other.TaskID.Length != 0) {
        TaskID = other.TaskID;
      }
      if (other.Status != global::Grpc.services.OTDRData.Types.Status.OnHold) {
        Status = other.Status;
      }
      if (other.Direction != global::Grpc.services.OTDRData.Types.Direction.None) {
        Direction = other.Direction;
      }
      if (other.Port != 0) {
        Port = other.Port;
      }
      if (other.LinkLoss != 0D) {
        LinkLoss = other.LinkLoss;
      }
      if (other.Length != 0D) {
        Length = other.Length;
      }
      if (other.Event != 0) {
        Event = other.Event;
      }
      if (other.MaxSplice != 0D) {
        MaxSplice = other.MaxSplice;
      }
      if (other.LinkORL != 0D) {
        LinkORL = other.LinkORL;
      }
      file_.Add(other.file_);
      filetype_.Add(other.filetype_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ObjectID = input.ReadInt64();
            break;
          }
          case 18: {
            TaskID = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Grpc.services.OTDRData.Types.Status) input.ReadEnum();
            break;
          }
          case 32: {
            Direction = (global::Grpc.services.OTDRData.Types.Direction) input.ReadEnum();
            break;
          }
          case 40: {
            Port = input.ReadInt32();
            break;
          }
          case 49: {
            LinkLoss = input.ReadDouble();
            break;
          }
          case 57: {
            Length = input.ReadDouble();
            break;
          }
          case 64: {
            Event = input.ReadInt32();
            break;
          }
          case 73: {
            MaxSplice = input.ReadDouble();
            break;
          }
          case 81: {
            LinkORL = input.ReadDouble();
            break;
          }
          case 90: {
            file_.AddEntriesFrom(input, _repeated_file_codec);
            break;
          }
          case 98: {
            filetype_.AddEntriesFrom(input, _repeated_filetype_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the OTDRData message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("ON_HOLD")] OnHold = 0,
        [pbr::OriginalName("COMPLETED")] Completed = 1,
      }

      public enum Direction {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("EAST")] East = 1,
        [pbr::OriginalName("WEST")] West = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
