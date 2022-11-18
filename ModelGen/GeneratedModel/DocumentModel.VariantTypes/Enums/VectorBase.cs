namespace DocumentModel.VariantTypes;

/// <summary>
/// Vector Base Type Simple Type
/// </summary>
public enum VectorBase
{
  /// <summary>
  /// Variant Base Type.
  /// </summary>
  [XmlEnum("variant")]
  Variant,
  
  /// <summary>
  /// Vector Base Type Enumeration Value.
  /// </summary>
  [XmlEnum("i1")]
  OneByteSignedInteger,
  
  /// <summary>
  /// 2-Byte Signed Integer Base Type.
  /// </summary>
  [XmlEnum("i2")]
  TwoBytesSignedInteger,
  
  /// <summary>
  /// 4-Byte Signed Integer Base Type.
  /// </summary>
  [XmlEnum("i4")]
  FourBytesSignedInteger,
  
  /// <summary>
  /// 8-Byte Signed Integer Base Type.
  /// </summary>
  [XmlEnum("i8")]
  EightBytesSignedInteger,
  
  /// <summary>
  /// 1-Byte Unsigned Integer Base Type.
  /// </summary>
  [XmlEnum("ui1")]
  OneByteUnsignedInteger,
  
  /// <summary>
  /// 2-Byte Unsigned Integer Base Type.
  /// </summary>
  [XmlEnum("ui2")]
  TwoBytesUnsignedInteger,
  
  /// <summary>
  /// 4-Byte Unsigned Integer Base Type.
  /// </summary>
  [XmlEnum("ui4")]
  FourBytesUnsignedInteger,
  
  /// <summary>
  /// 8-Byte Unsigned Integer Base Type.
  /// </summary>
  [XmlEnum("ui8")]
  EightBytesUnsignedInteger,
  
  /// <summary>
  /// 4-Byte Real Number Base Type.
  /// </summary>
  [XmlEnum("r4")]
  FourBytesReal,
  
  /// <summary>
  /// 8-Byte Real Number Base Type.
  /// </summary>
  [XmlEnum("r8")]
  EightBytesReal,
  
  /// <summary>
  /// LPSTR Base Type.
  /// </summary>
  [XmlEnum("lpstr")]
  Lpstr,
  
  /// <summary>
  /// LPWSTR Base Type.
  /// </summary>
  [XmlEnum("lpwstr")]
  Lpwstr,
  
  /// <summary>
  /// Basic String Base Type.
  /// </summary>
  [XmlEnum("bstr")]
  Bstr,
  
  /// <summary>
  /// Date and Time Base Type.
  /// </summary>
  [XmlEnum("date")]
  Date,
  
  /// <summary>
  /// File Time Base Type.
  /// </summary>
  [XmlEnum("filetime")]
  Filetime,
  
  /// <summary>
  /// Boolean Base Type.
  /// </summary>
  [XmlEnum("bool")]
  Bool,
  
  /// <summary>
  /// Currency Base Type.
  /// </summary>
  [XmlEnum("cy")]
  Currency,
  
  /// <summary>
  /// Error Status Code Base Type.
  /// </summary>
  [XmlEnum("error")]
  Error,
  
  /// <summary>
  /// Class ID Base Type.
  /// </summary>
  [XmlEnum("clsid")]
  ClassId,
  
  /// <summary>
  /// Clipboard Data Base Type.
  /// </summary>
  [XmlEnum("cf")]
  ClipboardData,
  
}
