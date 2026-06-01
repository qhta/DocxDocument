namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Array Variant ValueType Simple ValueType
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VariantType
{
  /// <summary>
  ///   For uninitialized Variant Ionly
  /// </summary>
  Empty,

  /// <summary>
  ///   1-Byte Signed Integer Variant ValueType.
  /// </summary>
  SByte,

  /// <summary>
  ///   2-Byte Signed Integer Variant ValueType.
  /// </summary>
  Int16,

  /// <summary>
  ///   4-Byte Signed Integer Variant ValueType.
  /// </summary>
  Int32,

  /// <summary>
  ///   8-Byte Signed Integer Variant ValueType.
  /// </summary>
  Int64,

  /// <summary>
  ///   Integer Variant ValueType.
  /// </summary>
  Integer,

  /// <summary>
  ///   1-Byte Unsigned Integer Variant ValueType.
  /// </summary>
  Byte,

  /// <summary>
  ///   2-Byte Unsigned Integer Variant ValueType.
  /// </summary>
  UInt16,

  /// <summary>
  ///   4-Byte Unsigned Integer Variant ValueType.
  /// </summary>
  UInt32,

  /// <summary>
  ///   8-Byte Unsigned Integer Variant ValueType.
  /// </summary>
  UInt64,

  /// <summary>
  ///   Unsigned Integer Variant ValueType.
  /// </summary>
  UnsignedInteger,

  /// <summary>
  ///   4-Byte Real Number Variant ValueType.
  /// </summary>
  Single,

  /// <summary>
  ///   8-Byte Real Number Variant ValueType.
  /// </summary>
  Double,

  /// <summary>
  ///   Decimal Variant ValueType.
  /// </summary>
  Decimal,

    /// <summary>
  ///   String Variant ValueType
  /// </summary>
  String,

  /// <summary>
  ///   LPSTR Variant ValueType.
  /// </summary>
  Lpstr,

  /// <summary>
  ///   LPWSTR Variant ValueType.
  /// </summary>
  Lpwstr,

  /// <summary>
  ///   Basic String Variant ValueType.
  /// </summary>
  Bstr,

  /// <summary>
  ///   Char Variant ValueType.
  /// </summary>
  Char,

  /// <summary>
  ///   Date and Time Variant ValueType.
  /// </summary>
  Date,

  /// <summary>
  ///   File Time Variant ValueType.
  /// </summary>
  DateTime,

  /// <summary>
  ///   Boolean Variant ValueType.
  /// </summary>
  Boolean,

  /// <summary>
  ///   Currency Variant ValueType.
  /// </summary>
  Currency,

  /// <summary>
  ///   Null Variant ValueType.
  /// </summary>
  Null,

  /// <summary>
  ///   Error Status Code Variant ValueType.
  /// </summary>
  HexInt,

  /// <summary>
  ///   Enum Variant ValueType.
  /// </summary>
  Enum,

  /// <summary>
  ///   IGlobal Unique ID Variant ValueType.
  /// </summary>
  Guid,

  /// <summary>
  ///   Clipboard Data Variant ValueType.
  /// </summary>
  ClipboardData,

  /// <summary>
  ///   Blob Variant ValueType.
  /// </summary>
  Blob,

  /// <summary>
  ///   OBlob Variant ValueType.
  /// </summary>
  OBlob,

  /// <summary>
  ///   Storage Variant ValueType.
  /// </summary>
  Storage,

  /// <summary>
  ///   OStorage Variant ValueType.
  /// </summary>
  OStorage,

  /// <summary>
  ///   VStream Variant ValueType.
  /// </summary>
  Stream,

  /// <summary>
  ///   OStream Variant ValueType.
  /// </summary>
  OStream,

  /// <summary>
  ///   VStream Variant ValueType.
  /// </summary>
  VStream,

  /// <summary>
  ///   Variant ValueType with internal Variant
  /// </summary>
  Variant,

  /// <summary>
  ///   Vector Variant ValueType.
  /// </summary>
  Vector,

  /// <summary>
  ///   Array Variant ValueType.
  /// </summary>
  Array,

  /// <summary>
  ///   Object Variant ValueType.
  /// </summary>
  Object,
}
