namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Vector Base Type Simple Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VectorBaseKind
{
  /// <summary>
  ///   Variant Base Type.
  /// </summary>
  Variant,

  /// <summary>
  ///   Vector Base Type Enumeration Value.
  /// </summary>
  OneByteSignedInteger,

  /// <summary>
  ///   2-Byte Signed Integer Base Type.
  /// </summary>
  TwoBytesSignedInteger,

  /// <summary>
  ///   4-Byte Signed Integer Base Type.
  /// </summary>
  FourBytesSignedInteger,

  /// <summary>
  ///   8-Byte Signed Integer Base Type.
  /// </summary>
  EightBytesSignedInteger,

  /// <summary>
  ///   1-Byte Unsigned Integer Base Type.
  /// </summary>
  OneByteUnsignedInteger,

  /// <summary>
  ///   2-Byte Unsigned Integer Base Type.
  /// </summary>
  TwoBytesUnsignedInteger,

  /// <summary>
  ///   4-Byte Unsigned Integer Base Type.
  /// </summary>
  FourBytesUnsignedInteger,

  /// <summary>
  ///   8-Byte Unsigned Integer Base Type.
  /// </summary>
  EightBytesUnsignedInteger,

  /// <summary>
  ///   4-Byte Real Number Base Type.
  /// </summary>
  FourBytesReal,

  /// <summary>
  ///   8-Byte Real Number Base Type.
  /// </summary>
  EightBytesReal,

  /// <summary>
  ///   LPSTR Base Type.
  /// </summary>
  Lpstr,

  /// <summary>
  ///   LPWSTR Base Type.
  /// </summary>
  Lpwstr,

  /// <summary>
  ///   Basic String Base Type.
  /// </summary>
  Bstr,

  /// <summary>
  ///   Date and Time Base Type.
  /// </summary>
  Date,

  /// <summary>
  ///   File Time Base Type.
  /// </summary>
  Filetime,

  /// <summary>
  ///   Boolean Base Type.
  /// </summary>
  Bool,

  /// <summary>
  ///   Currency Base Type.
  /// </summary>
  Currency,

  /// <summary>
  ///   Error Status Code Base Type.
  /// </summary>
  Error,

  /// <summary>
  ///   Class ID Base Type.
  /// </summary>
  ClassId,

  /// <summary>
  ///   Clipboard Data Base Type.
  /// </summary>
  ClipboardData
}