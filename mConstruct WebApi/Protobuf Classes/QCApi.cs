// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/mConstruct/QCApi.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.services {

  /// <summary>Holder for reflection information generated from protos/mConstruct/QCApi.proto</summary>
  public static partial class QCApiReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/mConstruct/QCApi.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QCApiReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1wcm90b3MvbUNvbnN0cnVjdC9RQ0FwaS5wcm90bxoTcHJvdG9zL0NvbW1v",
            "bi5wcm90bxojcHJvdG9zL21Db25zdHJ1Y3QvZGF0YS9RQ0RhdGEucHJvdG8a",
            "JXByb3Rvcy9tQ29uc3RydWN0L2RhdGEvVGFza0RhdGEucHJvdG8iRAoJUUNS",
            "ZXF1ZXN0EhAKCHVzZXJuYW1lGAEgASgJEg4KBnRhc2tJRBgCIAEoCRIVCgVs",
            "YXllchgDIAEoDjIGLkxheWVyIrIBCgpRQ1Jlc3BvbnNlEg4KBnRhc2tJRBgB",
            "IAEoCRIVCgVsYXllchgCIAEoDjIGLkxheWVyEi0KEXF1YWxpdHlDaGVja3Bv",
            "aW50GAMgAygLMhIuUXVhbGl0eUNoZWNrcG9pbnQSFAoKZmVBcHByb3ZlZBgE",
            "IAEoCEgAEhQKCnFlQXBwcm92ZWQYBSABKAhIABIUCgppbEFwcHJvdmVkGAYg",
            "ASgISABCDAoKaXNBcHByb3ZlZCLHAQoNU2F2ZVFDUmVxdWVzdBIQCgh1c2Vy",
            "bmFtZRgBIAEoCRIOCgZ0YXNrSUQYAiABKAkSFQoFbGF5ZXIYAyABKA4yBi5M",
            "YXllchItChFxdWFsaXR5Q2hlY2twb2ludBgEIAMoCzISLlF1YWxpdHlDaGVj",
            "a3BvaW50EhQKCmZlQXBwcm92ZWQYBSABKAhIABIUCgpxZUFwcHJvdmVkGAYg",
            "ASgISAASFAoKaWxBcHByb3ZlZBgHIAEoCEgAQgwKCmlzQXBwcm92ZWQiXwoQ",
            "UUNIaXN0b3J5UmVxdWVzdBIQCgh1c2VybmFtZRgBIAEoCRIOCgZ0YXNrSUQY",
            "AiABKAkSEgoKcXVlc3Rpb25JRBgDIAEoCRIVCgVsYXllchgEIAEoDjIGLkxh",
            "eWVyMpwBCgJRQxIwChVHZXRRdWFsaXR5Q2hlY2twb2ludHMSCi5RQ1JlcXVl",
            "c3QaCy5RQ1Jlc3BvbnNlEjMKFlNhdmVRdWFsaXR5Q2hlY2twb2ludHMSDi5T",
            "YXZlUUNSZXF1ZXN0GgkuUmVzcG9uc2USLwoMR2V0UUNIaXN0b3J5EhEuUUNI",
            "aXN0b3J5UmVxdWVzdBoMLlRhc2tIaXN0b3J5QikKF2NvbS5tQ29uc3RydWN0",
            "LnByb3RvYnVmqgINR3JwYy5zZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grpc.common.CommonReflection.Descriptor, global::Grpc.services.QCDataReflection.Descriptor, global::Grpc.services.TaskDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.services.QCRequest), global::Grpc.services.QCRequest.Parser, new[]{ "Username", "TaskID", "Layer" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.services.QCResponse), global::Grpc.services.QCResponse.Parser, new[]{ "TaskID", "Layer", "QualityCheckpoint", "FeApproved", "QeApproved", "IlApproved" }, new[]{ "IsApproved" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.services.SaveQCRequest), global::Grpc.services.SaveQCRequest.Parser, new[]{ "Username", "TaskID", "Layer", "QualityCheckpoint", "FeApproved", "QeApproved", "IlApproved" }, new[]{ "IsApproved" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.services.QCHistoryRequest), global::Grpc.services.QCHistoryRequest.Parser, new[]{ "Username", "TaskID", "QuestionID", "Layer" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QCRequest : pb::IMessage<QCRequest> {
    private static readonly pb::MessageParser<QCRequest> _parser = new pb::MessageParser<QCRequest>(() => new QCRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QCRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.services.QCApiReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCRequest(QCRequest other) : this() {
      username_ = other.username_;
      taskID_ = other.taskID_;
      layer_ = other.layer_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCRequest Clone() {
      return new QCRequest(this);
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 1;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "layer" field.</summary>
    public const int LayerFieldNumber = 3;
    private global::Grpc.common.Layer layer_ = global::Grpc.common.Layer.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.common.Layer Layer {
      get { return layer_; }
      set {
        layer_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QCRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QCRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Username != other.Username) return false;
      if (TaskID != other.TaskID) return false;
      if (Layer != other.Layer) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (TaskID.Length != 0) hash ^= TaskID.GetHashCode();
      if (Layer != global::Grpc.common.Layer.None) hash ^= Layer.GetHashCode();
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
      if (Username.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Username);
      }
      if (TaskID.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TaskID);
      }
      if (Layer != global::Grpc.common.Layer.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Layer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (TaskID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TaskID);
      }
      if (Layer != global::Grpc.common.Layer.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Layer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QCRequest other) {
      if (other == null) {
        return;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.TaskID.Length != 0) {
        TaskID = other.TaskID;
      }
      if (other.Layer != global::Grpc.common.Layer.None) {
        Layer = other.Layer;
      }
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
          case 10: {
            Username = input.ReadString();
            break;
          }
          case 18: {
            TaskID = input.ReadString();
            break;
          }
          case 24: {
            Layer = (global::Grpc.common.Layer) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class QCResponse : pb::IMessage<QCResponse> {
    private static readonly pb::MessageParser<QCResponse> _parser = new pb::MessageParser<QCResponse>(() => new QCResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QCResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.services.QCApiReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCResponse(QCResponse other) : this() {
      taskID_ = other.taskID_;
      layer_ = other.layer_;
      qualityCheckpoint_ = other.qualityCheckpoint_.Clone();
      switch (other.IsApprovedCase) {
        case IsApprovedOneofCase.FeApproved:
          FeApproved = other.FeApproved;
          break;
        case IsApprovedOneofCase.QeApproved:
          QeApproved = other.QeApproved;
          break;
        case IsApprovedOneofCase.IlApproved:
          IlApproved = other.IlApproved;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCResponse Clone() {
      return new QCResponse(this);
    }

    /// <summary>Field number for the "taskID" field.</summary>
    public const int TaskIDFieldNumber = 1;
    private string taskID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TaskID {
      get { return taskID_; }
      set {
        taskID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "layer" field.</summary>
    public const int LayerFieldNumber = 2;
    private global::Grpc.common.Layer layer_ = global::Grpc.common.Layer.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.common.Layer Layer {
      get { return layer_; }
      set {
        layer_ = value;
      }
    }

    /// <summary>Field number for the "qualityCheckpoint" field.</summary>
    public const int QualityCheckpointFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Grpc.services.QualityCheckpoint> _repeated_qualityCheckpoint_codec
        = pb::FieldCodec.ForMessage(26, global::Grpc.services.QualityCheckpoint.Parser);
    private readonly pbc::RepeatedField<global::Grpc.services.QualityCheckpoint> qualityCheckpoint_ = new pbc::RepeatedField<global::Grpc.services.QualityCheckpoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Grpc.services.QualityCheckpoint> QualityCheckpoint {
      get { return qualityCheckpoint_; }
    }

    /// <summary>Field number for the "feApproved" field.</summary>
    public const int FeApprovedFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool FeApproved {
      get { return isApprovedCase_ == IsApprovedOneofCase.FeApproved ? (bool) isApproved_ : false; }
      set {
        isApproved_ = value;
        isApprovedCase_ = IsApprovedOneofCase.FeApproved;
      }
    }

    /// <summary>Field number for the "qeApproved" field.</summary>
    public const int QeApprovedFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool QeApproved {
      get { return isApprovedCase_ == IsApprovedOneofCase.QeApproved ? (bool) isApproved_ : false; }
      set {
        isApproved_ = value;
        isApprovedCase_ = IsApprovedOneofCase.QeApproved;
      }
    }

    /// <summary>Field number for the "ilApproved" field.</summary>
    public const int IlApprovedFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IlApproved {
      get { return isApprovedCase_ == IsApprovedOneofCase.IlApproved ? (bool) isApproved_ : false; }
      set {
        isApproved_ = value;
        isApprovedCase_ = IsApprovedOneofCase.IlApproved;
      }
    }

    private object isApproved_;
    /// <summary>Enum of possible cases for the "isApproved" oneof.</summary>
    public enum IsApprovedOneofCase {
      None = 0,
      FeApproved = 4,
      QeApproved = 5,
      IlApproved = 6,
    }
    private IsApprovedOneofCase isApprovedCase_ = IsApprovedOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IsApprovedOneofCase IsApprovedCase {
      get { return isApprovedCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearIsApproved() {
      isApprovedCase_ = IsApprovedOneofCase.None;
      isApproved_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QCResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QCResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TaskID != other.TaskID) return false;
      if (Layer != other.Layer) return false;
      if(!qualityCheckpoint_.Equals(other.qualityCheckpoint_)) return false;
      if (FeApproved != other.FeApproved) return false;
      if (QeApproved != other.QeApproved) return false;
      if (IlApproved != other.IlApproved) return false;
      if (IsApprovedCase != other.IsApprovedCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TaskID.Length != 0) hash ^= TaskID.GetHashCode();
      if (Layer != global::Grpc.common.Layer.None) hash ^= Layer.GetHashCode();
      hash ^= qualityCheckpoint_.GetHashCode();
      if (isApprovedCase_ == IsApprovedOneofCase.FeApproved) hash ^= FeApproved.GetHashCode();
      if (isApprovedCase_ == IsApprovedOneofCase.QeApproved) hash ^= QeApproved.GetHashCode();
      if (isApprovedCase_ == IsApprovedOneofCase.IlApproved) hash ^= IlApproved.GetHashCode();
      hash ^= (int) isApprovedCase_;
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
      if (TaskID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TaskID);
      }
      if (Layer != global::Grpc.common.Layer.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Layer);
      }
      qualityCheckpoint_.WriteTo(output, _repeated_qualityCheckpoint_codec);
      if (isApprovedCase_ == IsApprovedOneofCase.FeApproved) {
        output.WriteRawTag(32);
        output.WriteBool(FeApproved);
      }
      if (isApprovedCase_ == IsApprovedOneofCase.QeApproved) {
        output.WriteRawTag(40);
        output.WriteBool(QeApproved);
      }
      if (isApprovedCase_ == IsApprovedOneofCase.IlApproved) {
        output.WriteRawTag(48);
        output.WriteBool(IlApproved);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TaskID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TaskID);
      }
      if (Layer != global::Grpc.common.Layer.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Layer);
      }
      size += qualityCheckpoint_.CalculateSize(_repeated_qualityCheckpoint_codec);
      if (isApprovedCase_ == IsApprovedOneofCase.FeApproved) {
        size += 1 + 1;
      }
      if (isApprovedCase_ == IsApprovedOneofCase.QeApproved) {
        size += 1 + 1;
      }
      if (isApprovedCase_ == IsApprovedOneofCase.IlApproved) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QCResponse other) {
      if (other == null) {
        return;
      }
      if (other.TaskID.Length != 0) {
        TaskID = other.TaskID;
      }
      if (other.Layer != global::Grpc.common.Layer.None) {
        Layer = other.Layer;
      }
      qualityCheckpoint_.Add(other.qualityCheckpoint_);
      switch (other.IsApprovedCase) {
        case IsApprovedOneofCase.FeApproved:
          FeApproved = other.FeApproved;
          break;
        case IsApprovedOneofCase.QeApproved:
          QeApproved = other.QeApproved;
          break;
        case IsApprovedOneofCase.IlApproved:
          IlApproved = other.IlApproved;
          break;
      }

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
          case 10: {
            TaskID = input.ReadString();
            break;
          }
          case 16: {
            Layer = (global::Grpc.common.Layer) input.ReadEnum();
            break;
          }
          case 26: {
            qualityCheckpoint_.AddEntriesFrom(input, _repeated_qualityCheckpoint_codec);
            break;
          }
          case 32: {
            FeApproved = input.ReadBool();
            break;
          }
          case 40: {
            QeApproved = input.ReadBool();
            break;
          }
          case 48: {
            IlApproved = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SaveQCRequest : pb::IMessage<SaveQCRequest> {
    private static readonly pb::MessageParser<SaveQCRequest> _parser = new pb::MessageParser<SaveQCRequest>(() => new SaveQCRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SaveQCRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.services.QCApiReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveQCRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveQCRequest(SaveQCRequest other) : this() {
      username_ = other.username_;
      taskID_ = other.taskID_;
      layer_ = other.layer_;
      qualityCheckpoint_ = other.qualityCheckpoint_.Clone();
      switch (other.IsApprovedCase) {
        case IsApprovedOneofCase.FeApproved:
          FeApproved = other.FeApproved;
          break;
        case IsApprovedOneofCase.QeApproved:
          QeApproved = other.QeApproved;
          break;
        case IsApprovedOneofCase.IlApproved:
          IlApproved = other.IlApproved;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveQCRequest Clone() {
      return new SaveQCRequest(this);
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 1;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "layer" field.</summary>
    public const int LayerFieldNumber = 3;
    private global::Grpc.common.Layer layer_ = global::Grpc.common.Layer.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.common.Layer Layer {
      get { return layer_; }
      set {
        layer_ = value;
      }
    }

    /// <summary>Field number for the "qualityCheckpoint" field.</summary>
    public const int QualityCheckpointFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Grpc.services.QualityCheckpoint> _repeated_qualityCheckpoint_codec
        = pb::FieldCodec.ForMessage(34, global::Grpc.services.QualityCheckpoint.Parser);
    private readonly pbc::RepeatedField<global::Grpc.services.QualityCheckpoint> qualityCheckpoint_ = new pbc::RepeatedField<global::Grpc.services.QualityCheckpoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Grpc.services.QualityCheckpoint> QualityCheckpoint {
      get { return qualityCheckpoint_; }
    }

    /// <summary>Field number for the "feApproved" field.</summary>
    public const int FeApprovedFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool FeApproved {
      get { return isApprovedCase_ == IsApprovedOneofCase.FeApproved ? (bool) isApproved_ : false; }
      set {
        isApproved_ = value;
        isApprovedCase_ = IsApprovedOneofCase.FeApproved;
      }
    }

    /// <summary>Field number for the "qeApproved" field.</summary>
    public const int QeApprovedFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool QeApproved {
      get { return isApprovedCase_ == IsApprovedOneofCase.QeApproved ? (bool) isApproved_ : false; }
      set {
        isApproved_ = value;
        isApprovedCase_ = IsApprovedOneofCase.QeApproved;
      }
    }

    /// <summary>Field number for the "ilApproved" field.</summary>
    public const int IlApprovedFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IlApproved {
      get { return isApprovedCase_ == IsApprovedOneofCase.IlApproved ? (bool) isApproved_ : false; }
      set {
        isApproved_ = value;
        isApprovedCase_ = IsApprovedOneofCase.IlApproved;
      }
    }

    private object isApproved_;
    /// <summary>Enum of possible cases for the "isApproved" oneof.</summary>
    public enum IsApprovedOneofCase {
      None = 0,
      FeApproved = 5,
      QeApproved = 6,
      IlApproved = 7,
    }
    private IsApprovedOneofCase isApprovedCase_ = IsApprovedOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IsApprovedOneofCase IsApprovedCase {
      get { return isApprovedCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearIsApproved() {
      isApprovedCase_ = IsApprovedOneofCase.None;
      isApproved_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SaveQCRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SaveQCRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Username != other.Username) return false;
      if (TaskID != other.TaskID) return false;
      if (Layer != other.Layer) return false;
      if(!qualityCheckpoint_.Equals(other.qualityCheckpoint_)) return false;
      if (FeApproved != other.FeApproved) return false;
      if (QeApproved != other.QeApproved) return false;
      if (IlApproved != other.IlApproved) return false;
      if (IsApprovedCase != other.IsApprovedCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (TaskID.Length != 0) hash ^= TaskID.GetHashCode();
      if (Layer != global::Grpc.common.Layer.None) hash ^= Layer.GetHashCode();
      hash ^= qualityCheckpoint_.GetHashCode();
      if (isApprovedCase_ == IsApprovedOneofCase.FeApproved) hash ^= FeApproved.GetHashCode();
      if (isApprovedCase_ == IsApprovedOneofCase.QeApproved) hash ^= QeApproved.GetHashCode();
      if (isApprovedCase_ == IsApprovedOneofCase.IlApproved) hash ^= IlApproved.GetHashCode();
      hash ^= (int) isApprovedCase_;
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
      if (Username.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Username);
      }
      if (TaskID.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TaskID);
      }
      if (Layer != global::Grpc.common.Layer.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Layer);
      }
      qualityCheckpoint_.WriteTo(output, _repeated_qualityCheckpoint_codec);
      if (isApprovedCase_ == IsApprovedOneofCase.FeApproved) {
        output.WriteRawTag(40);
        output.WriteBool(FeApproved);
      }
      if (isApprovedCase_ == IsApprovedOneofCase.QeApproved) {
        output.WriteRawTag(48);
        output.WriteBool(QeApproved);
      }
      if (isApprovedCase_ == IsApprovedOneofCase.IlApproved) {
        output.WriteRawTag(56);
        output.WriteBool(IlApproved);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (TaskID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TaskID);
      }
      if (Layer != global::Grpc.common.Layer.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Layer);
      }
      size += qualityCheckpoint_.CalculateSize(_repeated_qualityCheckpoint_codec);
      if (isApprovedCase_ == IsApprovedOneofCase.FeApproved) {
        size += 1 + 1;
      }
      if (isApprovedCase_ == IsApprovedOneofCase.QeApproved) {
        size += 1 + 1;
      }
      if (isApprovedCase_ == IsApprovedOneofCase.IlApproved) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SaveQCRequest other) {
      if (other == null) {
        return;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.TaskID.Length != 0) {
        TaskID = other.TaskID;
      }
      if (other.Layer != global::Grpc.common.Layer.None) {
        Layer = other.Layer;
      }
      qualityCheckpoint_.Add(other.qualityCheckpoint_);
      switch (other.IsApprovedCase) {
        case IsApprovedOneofCase.FeApproved:
          FeApproved = other.FeApproved;
          break;
        case IsApprovedOneofCase.QeApproved:
          QeApproved = other.QeApproved;
          break;
        case IsApprovedOneofCase.IlApproved:
          IlApproved = other.IlApproved;
          break;
      }

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
          case 10: {
            Username = input.ReadString();
            break;
          }
          case 18: {
            TaskID = input.ReadString();
            break;
          }
          case 24: {
            Layer = (global::Grpc.common.Layer) input.ReadEnum();
            break;
          }
          case 34: {
            qualityCheckpoint_.AddEntriesFrom(input, _repeated_qualityCheckpoint_codec);
            break;
          }
          case 40: {
            FeApproved = input.ReadBool();
            break;
          }
          case 48: {
            QeApproved = input.ReadBool();
            break;
          }
          case 56: {
            IlApproved = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class QCHistoryRequest : pb::IMessage<QCHistoryRequest> {
    private static readonly pb::MessageParser<QCHistoryRequest> _parser = new pb::MessageParser<QCHistoryRequest>(() => new QCHistoryRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QCHistoryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.services.QCApiReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCHistoryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCHistoryRequest(QCHistoryRequest other) : this() {
      username_ = other.username_;
      taskID_ = other.taskID_;
      questionID_ = other.questionID_;
      layer_ = other.layer_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QCHistoryRequest Clone() {
      return new QCHistoryRequest(this);
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 1;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "questionID" field.</summary>
    public const int QuestionIDFieldNumber = 3;
    private string questionID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string QuestionID {
      get { return questionID_; }
      set {
        questionID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "layer" field.</summary>
    public const int LayerFieldNumber = 4;
    private global::Grpc.common.Layer layer_ = global::Grpc.common.Layer.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.common.Layer Layer {
      get { return layer_; }
      set {
        layer_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QCHistoryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QCHistoryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Username != other.Username) return false;
      if (TaskID != other.TaskID) return false;
      if (QuestionID != other.QuestionID) return false;
      if (Layer != other.Layer) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (TaskID.Length != 0) hash ^= TaskID.GetHashCode();
      if (QuestionID.Length != 0) hash ^= QuestionID.GetHashCode();
      if (Layer != global::Grpc.common.Layer.None) hash ^= Layer.GetHashCode();
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
      if (Username.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Username);
      }
      if (TaskID.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TaskID);
      }
      if (QuestionID.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(QuestionID);
      }
      if (Layer != global::Grpc.common.Layer.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Layer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (TaskID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TaskID);
      }
      if (QuestionID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QuestionID);
      }
      if (Layer != global::Grpc.common.Layer.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Layer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QCHistoryRequest other) {
      if (other == null) {
        return;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.TaskID.Length != 0) {
        TaskID = other.TaskID;
      }
      if (other.QuestionID.Length != 0) {
        QuestionID = other.QuestionID;
      }
      if (other.Layer != global::Grpc.common.Layer.None) {
        Layer = other.Layer;
      }
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
          case 10: {
            Username = input.ReadString();
            break;
          }
          case 18: {
            TaskID = input.ReadString();
            break;
          }
          case 26: {
            QuestionID = input.ReadString();
            break;
          }
          case 32: {
            Layer = (global::Grpc.common.Layer) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
