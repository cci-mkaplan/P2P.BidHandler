// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/AuctionService - Copy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from protos/AuctionService - Copy.proto</summary>
public static partial class AuctionServiceCopyReflection {

  #region Descriptor
  /// <summary>File descriptor for protos/AuctionService - Copy.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AuctionServiceCopyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiJwcm90b3MvQXVjdGlvblNlcnZpY2UgLSBDb3B5LnByb3RvIkMKFkluaXRp",
          "YXRlQXVjdGlvblJlcXVlc3QSEQoJaXRlbV9uYW1lGAEgASgJEhYKDnN0YXJ0",
          "aW5nX3ByaWNlGAIgASgBIi0KF0luaXRpYXRlQXVjdGlvblJlc3BvbnNlEhIK",
          "CmF1Y3Rpb25faWQYASABKAUiSQoPUGxhY2VCaWRSZXF1ZXN0EhIKCmF1Y3Rp",
          "b25faWQYASABKAUSEgoKYmlkX2Ftb3VudBgCIAEoARIOCgZiaWRkZXIYAyAB",
          "KAkiJAoQUGxhY2VCaWRSZXNwb25zZRIQCghhY2NlcHRlZBgBIAEoCDKHAQoO",
          "QXVjdGlvblNlcnZpY2USRAoPSW5pdGlhdGVBdWN0aW9uEhcuSW5pdGlhdGVB",
          "dWN0aW9uUmVxdWVzdBoYLkluaXRpYXRlQXVjdGlvblJlc3BvbnNlEi8KCFBs",
          "YWNlQmlkEhAuUGxhY2VCaWRSZXF1ZXN0GhEuUGxhY2VCaWRSZXNwb25zZWIG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::InitiateAuctionRequest), global::InitiateAuctionRequest.Parser, new[]{ "ItemName", "StartingPrice" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::InitiateAuctionResponse), global::InitiateAuctionResponse.Parser, new[]{ "AuctionId" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::PlaceBidRequest), global::PlaceBidRequest.Parser, new[]{ "AuctionId", "BidAmount", "Bidder" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::PlaceBidResponse), global::PlaceBidResponse.Parser, new[]{ "Accepted" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class InitiateAuctionRequest : pb::IMessage<InitiateAuctionRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InitiateAuctionRequest> _parser = new pb::MessageParser<InitiateAuctionRequest>(() => new InitiateAuctionRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InitiateAuctionRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuctionServiceCopyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InitiateAuctionRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InitiateAuctionRequest(InitiateAuctionRequest other) : this() {
    itemName_ = other.itemName_;
    startingPrice_ = other.startingPrice_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InitiateAuctionRequest Clone() {
    return new InitiateAuctionRequest(this);
  }

  /// <summary>Field number for the "item_name" field.</summary>
  public const int ItemNameFieldNumber = 1;
  private string itemName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ItemName {
    get { return itemName_; }
    set {
      itemName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "starting_price" field.</summary>
  public const int StartingPriceFieldNumber = 2;
  private double startingPrice_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public double StartingPrice {
    get { return startingPrice_; }
    set {
      startingPrice_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InitiateAuctionRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InitiateAuctionRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ItemName != other.ItemName) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(StartingPrice, other.StartingPrice)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ItemName.Length != 0) hash ^= ItemName.GetHashCode();
    if (StartingPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(StartingPrice);
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (ItemName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(ItemName);
    }
    if (StartingPrice != 0D) {
      output.WriteRawTag(17);
      output.WriteDouble(StartingPrice);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (ItemName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(ItemName);
    }
    if (StartingPrice != 0D) {
      output.WriteRawTag(17);
      output.WriteDouble(StartingPrice);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (ItemName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemName);
    }
    if (StartingPrice != 0D) {
      size += 1 + 8;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InitiateAuctionRequest other) {
    if (other == null) {
      return;
    }
    if (other.ItemName.Length != 0) {
      ItemName = other.ItemName;
    }
    if (other.StartingPrice != 0D) {
      StartingPrice = other.StartingPrice;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          ItemName = input.ReadString();
          break;
        }
        case 17: {
          StartingPrice = input.ReadDouble();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          ItemName = input.ReadString();
          break;
        }
        case 17: {
          StartingPrice = input.ReadDouble();
          break;
        }
      }
    }
  }
  #endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class InitiateAuctionResponse : pb::IMessage<InitiateAuctionResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InitiateAuctionResponse> _parser = new pb::MessageParser<InitiateAuctionResponse>(() => new InitiateAuctionResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InitiateAuctionResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuctionServiceCopyReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InitiateAuctionResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InitiateAuctionResponse(InitiateAuctionResponse other) : this() {
    auctionId_ = other.auctionId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InitiateAuctionResponse Clone() {
    return new InitiateAuctionResponse(this);
  }

  /// <summary>Field number for the "auction_id" field.</summary>
  public const int AuctionIdFieldNumber = 1;
  private int auctionId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int AuctionId {
    get { return auctionId_; }
    set {
      auctionId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InitiateAuctionResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InitiateAuctionResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (AuctionId != other.AuctionId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (AuctionId != 0) hash ^= AuctionId.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (AuctionId != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(AuctionId);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (AuctionId != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(AuctionId);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (AuctionId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(AuctionId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InitiateAuctionResponse other) {
    if (other == null) {
      return;
    }
    if (other.AuctionId != 0) {
      AuctionId = other.AuctionId;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          AuctionId = input.ReadInt32();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          AuctionId = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class PlaceBidRequest : pb::IMessage<PlaceBidRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PlaceBidRequest> _parser = new pb::MessageParser<PlaceBidRequest>(() => new PlaceBidRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PlaceBidRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuctionServiceCopyReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlaceBidRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlaceBidRequest(PlaceBidRequest other) : this() {
    auctionId_ = other.auctionId_;
    bidAmount_ = other.bidAmount_;
    bidder_ = other.bidder_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlaceBidRequest Clone() {
    return new PlaceBidRequest(this);
  }

  /// <summary>Field number for the "auction_id" field.</summary>
  public const int AuctionIdFieldNumber = 1;
  private int auctionId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int AuctionId {
    get { return auctionId_; }
    set {
      auctionId_ = value;
    }
  }

  /// <summary>Field number for the "bid_amount" field.</summary>
  public const int BidAmountFieldNumber = 2;
  private double bidAmount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public double BidAmount {
    get { return bidAmount_; }
    set {
      bidAmount_ = value;
    }
  }

  /// <summary>Field number for the "bidder" field.</summary>
  public const int BidderFieldNumber = 3;
  private string bidder_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Bidder {
    get { return bidder_; }
    set {
      bidder_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PlaceBidRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PlaceBidRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (AuctionId != other.AuctionId) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BidAmount, other.BidAmount)) return false;
    if (Bidder != other.Bidder) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (AuctionId != 0) hash ^= AuctionId.GetHashCode();
    if (BidAmount != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BidAmount);
    if (Bidder.Length != 0) hash ^= Bidder.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (AuctionId != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(AuctionId);
    }
    if (BidAmount != 0D) {
      output.WriteRawTag(17);
      output.WriteDouble(BidAmount);
    }
    if (Bidder.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Bidder);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (AuctionId != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(AuctionId);
    }
    if (BidAmount != 0D) {
      output.WriteRawTag(17);
      output.WriteDouble(BidAmount);
    }
    if (Bidder.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Bidder);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (AuctionId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(AuctionId);
    }
    if (BidAmount != 0D) {
      size += 1 + 8;
    }
    if (Bidder.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Bidder);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PlaceBidRequest other) {
    if (other == null) {
      return;
    }
    if (other.AuctionId != 0) {
      AuctionId = other.AuctionId;
    }
    if (other.BidAmount != 0D) {
      BidAmount = other.BidAmount;
    }
    if (other.Bidder.Length != 0) {
      Bidder = other.Bidder;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          AuctionId = input.ReadInt32();
          break;
        }
        case 17: {
          BidAmount = input.ReadDouble();
          break;
        }
        case 26: {
          Bidder = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          AuctionId = input.ReadInt32();
          break;
        }
        case 17: {
          BidAmount = input.ReadDouble();
          break;
        }
        case 26: {
          Bidder = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class PlaceBidResponse : pb::IMessage<PlaceBidResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PlaceBidResponse> _parser = new pb::MessageParser<PlaceBidResponse>(() => new PlaceBidResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PlaceBidResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AuctionServiceCopyReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlaceBidResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlaceBidResponse(PlaceBidResponse other) : this() {
    accepted_ = other.accepted_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlaceBidResponse Clone() {
    return new PlaceBidResponse(this);
  }

  /// <summary>Field number for the "accepted" field.</summary>
  public const int AcceptedFieldNumber = 1;
  private bool accepted_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Accepted {
    get { return accepted_; }
    set {
      accepted_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PlaceBidResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PlaceBidResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Accepted != other.Accepted) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Accepted != false) hash ^= Accepted.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Accepted != false) {
      output.WriteRawTag(8);
      output.WriteBool(Accepted);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Accepted != false) {
      output.WriteRawTag(8);
      output.WriteBool(Accepted);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Accepted != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PlaceBidResponse other) {
    if (other == null) {
      return;
    }
    if (other.Accepted != false) {
      Accepted = other.Accepted;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Accepted = input.ReadBool();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          Accepted = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
