namespace DocumentModel.VariantTypes;

/// <summary>
/// Array Base Type Simple Type
/// </summary>
public enum ArrayBaseValues
{
  /// <summary>
  /// Variant Base Type.
  /// </summary>
  [XmlEnum("variant")]
  Variant,
  
  /// <summary>
  /// 1-Byte Signed Integer Base Type.
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
  /// Integer Base Type.
  /// </summary>
  [XmlEnum("int")]
  Integer,
  
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
  /// Unsigned Integer Base Type.
  /// </summary>
  [XmlEnum("uint")]
  UnsignedInteger,
  
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
  /// Decimal Base Type.
  /// </summary>
  [XmlEnum("decimal")]
  Decimal,
  
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
  
}
