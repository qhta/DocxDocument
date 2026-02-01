namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Array Base Type Simple Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVT.ArrayBaseValues))]
public enum ArrayBaseKind
{
  /// <summary>
  ///   Variant Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.Variant))]
  Variant,
  /// <summary>
  ///   1-Byte Signed Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.OneByteSignedInteger))]
  OneByteSignedInteger,
  /// <summary>
  ///   2-Byte Signed Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.TwoBytesSignedInteger))]
  TwoBytesSignedInteger,
  /// <summary>
  ///   4-Byte Signed Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.FourBytesSignedInteger))]
  FourBytesSignedInteger,
  /// <summary>
  ///   Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.Integer))]
  Integer,
  /// <summary>
  ///   1-Byte Unsigned Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.OneByteUnsignedInteger))]
  OneByteUnsignedInteger,
  /// <summary>
  ///   2-Byte Unsigned Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.TwoBytesUnsignedInteger))]
  TwoBytesUnsignedInteger,
  /// <summary>
  ///   4-Byte Unsigned Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.FourBytesUnsignedInteger))]
  FourBytesUnsignedInteger,
  /// <summary>
  ///   Unsigned Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.UnsignedInteger))]
  UnsignedInteger,
  /// <summary>
  ///   4-Byte Real Number Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.FourBytesReal))]
  FourBytesReal,
  /// <summary>
  ///   8-Byte Real Number Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.EightBytesReal))]
  EightBytesReal,
  /// <summary>
  ///   Decimal Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.Decimal))]
  Decimal,
  /// <summary>
  ///   Basic String Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.Bstr))]
  Bstr,
  /// <summary>
  ///   Date and Time Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.Date))]
  Date,
  /// <summary>
  ///   Boolean Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.Bool))]
  Bool,
  /// <summary>
  ///   Currency Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.Currency))]
  Currency,
  /// <summary>
  ///   Error Status Code Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.ArrayBaseValues.Error))]
  Error
}