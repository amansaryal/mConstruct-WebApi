// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/K2Data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.services {

  /// <summary>Holder for reflection information generated from protos/K2Data.proto</summary>
  public static partial class K2DataReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/K2Data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static K2DataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNwcm90b3MvSzJEYXRhLnByb3RvIoIBCghKaW9Qb2ludBIOCgZqcE5hbWUY",
            "ASABKAkSDgoGanBDb2RlGAIgASgJEgwKBGpwSUQYAyABKAkSEAoIY2l0eU5h",
            "bWUYBCABKAkSEAoIY2l0eUNvZGUYBSABKAkSEQoJc3RhdGVOYW1lGAYgASgJ",
            "EhEKCXN0YXRlQ29kZRgHIAEoCSpcCgZLMlJvbGUSDgoKSzJfTk9fUk9MRRAA",
            "EhgKFEpDX0NPTlNUUlVDVElPTl9MRUFEEAESDwoLSlBfRU5HSU5FRVIQAhIX",
            "ChNKUF9RVUFMSVRZX0VOR0lORUVSEANCKQoXY29tLm1Db25zdHJ1Y3QucHJv",
            "dG9idWaqAg1HcnBjLnNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Grpc.services.K2Role), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.services.JioPoint), global::Grpc.services.JioPoint.Parser, new[]{ "JpName", "JpCode", "JpID", "CityName", "CityCode", "StateName", "StateCode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum K2Role {
    [pbr::OriginalName("K2_NO_ROLE")] K2NoRole = 0,
    /// <summary>
    ///IL
    /// </summary>
    [pbr::OriginalName("JC_CONSTRUCTION_LEAD")] JcConstructionLead = 1,
    /// <summary>
    ///FE
    /// </summary>
    [pbr::OriginalName("JP_ENGINEER")] JpEngineer = 2,
    /// <summary>
    ///QE
    /// </summary>
    [pbr::OriginalName("JP_QUALITY_ENGINEER")] JpQualityEngineer = 3,
  }

  #endregion

  #region Messages
  public sealed partial class JioPoint : pb::IMessage<JioPoint> {
    private static readonly pb::MessageParser<JioPoint> _parser = new pb::MessageParser<JioPoint>(() => new JioPoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<JioPoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.services.K2DataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JioPoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JioPoint(JioPoint other) : this() {
      jpName_ = other.jpName_;
      jpCode_ = other.jpCode_;
      jpID_ = other.jpID_;
      cityName_ = other.cityName_;
      cityCode_ = other.cityCode_;
      stateName_ = other.stateName_;
      stateCode_ = other.stateCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JioPoint Clone() {
      return new JioPoint(this);
    }

    /// <summary>Field number for the "jpName" field.</summary>
    public const int JpNameFieldNumber = 1;
    private string jpName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JpName {
      get { return jpName_; }
      set {
        jpName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "jpCode" field.</summary>
    public const int JpCodeFieldNumber = 2;
    private string jpCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JpCode {
      get { return jpCode_; }
      set {
        jpCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "jpID" field.</summary>
    public const int JpIDFieldNumber = 3;
    private string jpID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JpID {
      get { return jpID_; }
      set {
        jpID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cityName" field.</summary>
    public const int CityNameFieldNumber = 4;
    private string cityName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CityName {
      get { return cityName_; }
      set {
        cityName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cityCode" field.</summary>
    public const int CityCodeFieldNumber = 5;
    private string cityCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CityCode {
      get { return cityCode_; }
      set {
        cityCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stateName" field.</summary>
    public const int StateNameFieldNumber = 6;
    private string stateName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StateName {
      get { return stateName_; }
      set {
        stateName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stateCode" field.</summary>
    public const int StateCodeFieldNumber = 7;
    private string stateCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StateCode {
      get { return stateCode_; }
      set {
        stateCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as JioPoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(JioPoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JpName != other.JpName) return false;
      if (JpCode != other.JpCode) return false;
      if (JpID != other.JpID) return false;
      if (CityName != other.CityName) return false;
      if (CityCode != other.CityCode) return false;
      if (StateName != other.StateName) return false;
      if (StateCode != other.StateCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JpName.Length != 0) hash ^= JpName.GetHashCode();
      if (JpCode.Length != 0) hash ^= JpCode.GetHashCode();
      if (JpID.Length != 0) hash ^= JpID.GetHashCode();
      if (CityName.Length != 0) hash ^= CityName.GetHashCode();
      if (CityCode.Length != 0) hash ^= CityCode.GetHashCode();
      if (StateName.Length != 0) hash ^= StateName.GetHashCode();
      if (StateCode.Length != 0) hash ^= StateCode.GetHashCode();
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
      if (JpName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JpName);
      }
      if (JpCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(JpCode);
      }
      if (JpID.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(JpID);
      }
      if (CityName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CityName);
      }
      if (CityCode.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CityCode);
      }
      if (StateName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(StateName);
      }
      if (StateCode.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(StateCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JpName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JpName);
      }
      if (JpCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JpCode);
      }
      if (JpID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JpID);
      }
      if (CityName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CityName);
      }
      if (CityCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CityCode);
      }
      if (StateName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StateName);
      }
      if (StateCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StateCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(JioPoint other) {
      if (other == null) {
        return;
      }
      if (other.JpName.Length != 0) {
        JpName = other.JpName;
      }
      if (other.JpCode.Length != 0) {
        JpCode = other.JpCode;
      }
      if (other.JpID.Length != 0) {
        JpID = other.JpID;
      }
      if (other.CityName.Length != 0) {
        CityName = other.CityName;
      }
      if (other.CityCode.Length != 0) {
        CityCode = other.CityCode;
      }
      if (other.StateName.Length != 0) {
        StateName = other.StateName;
      }
      if (other.StateCode.Length != 0) {
        StateCode = other.StateCode;
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
            JpName = input.ReadString();
            break;
          }
          case 18: {
            JpCode = input.ReadString();
            break;
          }
          case 26: {
            JpID = input.ReadString();
            break;
          }
          case 34: {
            CityName = input.ReadString();
            break;
          }
          case 42: {
            CityCode = input.ReadString();
            break;
          }
          case 50: {
            StateName = input.ReadString();
            break;
          }
          case 58: {
            StateCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
