namespace DocumentModel.VariantTypes;

/// <summary>
/// Array Base Type Simple Type
/// </summary>
public enum ArrayBaseKind
{
  /// <summary>
  /// Variant Base Type.
  /// </summary>
  Variant,
  
  /// <summary>
  /// 1-Byte Signed Integer Base Type.
  /// </summary>
  OneByteSignedInteger,
  
  /// <summary>
  /// 2-Byte Signed Integer Base Type.
  /// </summary>
  TwoBytesSignedInteger,
  
  /// <summary>
  /// 4-Byte Signed Integer Base Type.
  /// </summary>
  FourBytesSignedInteger,
  
  /// <summary>
  /// Integer Base Type.
  /// </summary>
  Integer,
  
  /// <summary>
  /// 1-Byte Unsigned Integer Base Type.
  /// </summary>
  OneByteUnsignedInteger,
  
  /// <summary>
  /// 2-Byte Unsigned Integer Base Type.
  /// </summary>
  TwoBytesUnsignedInteger,
  
  /// <summary>
  /// 4-Byte Unsigned Integer Base Type.
  /// </summary>
  FourBytesUnsignedInteger,
  
  /// <summary>
  /// Unsigned Integer Base Type.
  /// </summary>
  UnsignedInteger,
  
  /// <summary>
  /// 4-Byte Real Number Base Type.
  /// </summary>
  FourBytesReal,
  
  /// <summary>
  /// 8-Byte Real Number Base Type.
  /// </summary>
  EightBytesReal,
  
  /// <summary>
  /// Decimal Base Type.
  /// </summary>
  Decimal,
  
  /// <summary>
  /// Basic String Base Type.
  /// </summary>
  Bstr,
  
  /// <summary>
  /// Date and Time Base Type.
  /// </summary>
  Date,
  
  /// <summary>
  /// Boolean Base Type.
  /// </summary>
  Bool,
  
  /// <summary>
  /// Currency Base Type.
  /// </summary>
  Currency,
  
  /// <summary>
  /// Error Status Code Base Type.
  /// </summary>
  Error,
  
}
