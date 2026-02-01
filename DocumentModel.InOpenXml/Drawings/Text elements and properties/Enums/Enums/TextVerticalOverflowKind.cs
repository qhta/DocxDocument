namespace DocumentModel.Drawings;
/// <summary>
///   Text Vertical Overflow
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextVerticalOverflowValues))]
public enum TextVerticalOverflowKind
{
  /// <summary>
  ///   Text Overflow Enum ( Overflow ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalOverflowValues.Overflow))]
  Overflow,
  /// <summary>
  ///   Text Overflow Enum ( Ellipsis ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalOverflowValues.Ellipsis))]
  Ellipsis,
  /// <summary>
  ///   Text Overflow Enum ( Clip ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextVerticalOverflowValues.Clip))]
  Clip
}