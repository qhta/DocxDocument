namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Vector Base Type Simple Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVT.VectorBaseValues))]
public enum VectorBaseType
{
  /// <summary>
  ///   Variant Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Variant))]
  Variant,
  /// <summary>
  ///   Vector Base Type Enumeration Value.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.OneByteSignedInteger))]
  OneByteSignedInteger,
  /// <summary>
  ///   2-Byte Signed Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.TwoBytesSignedInteger))]
  TwoBytesSignedInteger,
  /// <summary>
  ///   4-Byte Signed Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.FourBytesSignedInteger))]
  FourBytesSignedInteger,
  /// <summary>
  ///   8-Byte Signed Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.EightBytesSignedInteger))]
  EightBytesSignedInteger,
  /// <summary>
  ///   1-Byte Unsigned Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.OneByteUnsignedInteger))]
  OneByteUnsignedInteger,
  /// <summary>
  ///   2-Byte Unsigned Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.TwoBytesUnsignedInteger))]
  TwoBytesUnsignedInteger,
  /// <summary>
  ///   4-Byte Unsigned Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.FourBytesUnsignedInteger))]
  FourBytesUnsignedInteger,
  /// <summary>
  ///   8-Byte Unsigned Integer Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.EightBytesUnsignedInteger))]
  EightBytesUnsignedInteger,
  /// <summary>
  ///   4-Byte Real Number Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.FourBytesReal))]
  FourBytesReal,
  /// <summary>
  ///   8-Byte Real Number Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.EightBytesReal))]
  EightBytesReal,
  /// <summary>
  ///   LPSTR Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Lpstr))]
  Lpstr,
  /// <summary>
  ///   LPWSTR Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Lpwstr))]
  Lpwstr,
  /// <summary>
  ///   Basic String Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Bstr))]
  Bstr,
  /// <summary>
  ///   Date and Time Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Date))]
  Date,
  /// <summary>
  ///   File Time Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Filetime))]
  Filetime,
  /// <summary>
  ///   Boolean Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Bool))]
  Bool,
  /// <summary>
  ///   Currency Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Currency))]
  Currency,
  /// <summary>
  ///   Error Status Code Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.Error))]
  Error,
  /// <summary>
  ///   Class ID Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.ClassId))]
  ClassId,
  /// <summary>
  ///   Clipboard Data Base Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVT.VectorBaseValues.ClipboardData))]
  ClipboardData
}