namespace DocumentModel;

/// <summary>
/// Array Variant Type Simple Type
/// </summary>
public enum VariantType
{
  /// <summary>
  /// Variant Variant Type.
  /// </summary>
  Variant,
  
  /// <summary>
  /// 1-Byte Signed Integer Variant Type.
  /// </summary>
  SByte,
  
  /// <summary>
  /// 2-Byte Signed Integer Variant Type.
  /// </summary>
  Int16,
  
  /// <summary>
  /// 4-Byte Signed Integer Variant Type.
  /// </summary>
  Int32,

  /// <summary>
  /// 8-Byte Signed Integer Variant Type.
  /// </summary>
  Int64,

  /// <summary>
  /// Integer Variant Type.
  /// </summary>
  Integer,
  
  /// <summary>
  /// 1-Byte Unsigned Integer Variant Type.
  /// </summary>
  Byte,
  
  /// <summary>
  /// 2-Byte Unsigned Integer Variant Type.
  /// </summary>
  UInt16,
  
  /// <summary>
  /// 4-Byte Unsigned Integer Variant Type.
  /// </summary>
  UInt32,

  /// <summary>
  /// 8-Byte Unsigned Integer Variant Type.
  /// </summary>
  UInt64,

  /// <summary>
  /// Unsigned Integer Variant Type.
  /// </summary>
  UnsignedInteger,
  
  /// <summary>
  /// 4-Byte Real Number Variant Type.
  /// </summary>
  Single,
  
  /// <summary>
  /// 8-Byte Real Number Variant Type.
  /// </summary>
  Double,
  
  /// <summary>
  /// Decimal Variant Type.
  /// </summary>
  Decimal,

  /// <summary>
  /// LPSTR Variant Type.
  /// </summary>
  Lpstr,

  /// <summary>
  /// LPWSTR Variant Type.
  /// </summary>
  Lpwstr,

  /// <summary>
  /// Basic String Variant Type.
  /// </summary>
  Bstr,

  /// <summary>
  /// Char Variant Type.
  /// </summary>
  Char,

  /// <summary>
  /// Date and Time Variant Type.
  /// </summary>
  Date,

  /// <summary>
  /// File Time Variant Type.
  /// </summary>
  DateTime,

  /// <summary>
  /// Boolean Variant Type.
  /// </summary>
  Boolean,
  
  /// <summary>
  /// Currency Variant Type.
  /// </summary>
  Currency,

  /// <summary>
  /// Null Variant Type.
  /// </summary>
  Null,

  /// <summary>
  /// Empty Variant Type.
  /// </summary>
  Empty,

  /// <summary>
  /// Error Status Code Variant Type.
  /// </summary>
  HexInt,

  /// <summary>
  /// Class ID Variant Type.
  /// </summary>
  Guid,

  /// <summary>
  /// Clipboard Data Variant Type.
  /// </summary>
  ClipboardData,

  /// <summary>
  /// Blob Variant Type.
  /// </summary>
  Blob,

  /// <summary>
  /// OBlob Variant Type.
  /// </summary>
  OBlob,

  /// <summary>
  /// Storage Variant Type.
  /// </summary>
  Storage,

  /// <summary>
  /// OStorage Variant Type.
  /// </summary>
  OStorage,

  /// <summary>
  /// VStream Variant Type.
  /// </summary>
  Stream,

  /// <summary>
  /// OStream Variant Type.
  /// </summary>
  OStream,

  /// <summary>
  /// VStream Variant Type.
  /// </summary>
  VStream,

  /// <summary>
  /// Vector Variant Type.
  /// </summary>
  Vector,

  /// <summary>
  /// Array Variant Type.
  /// </summary>
  Array,

  /// <summary>
  /// Variant representing enum type
  /// </summary>
  Enum,

  /// <summary>
  /// Variant representing object type
  /// </summary>
  Object,
}
