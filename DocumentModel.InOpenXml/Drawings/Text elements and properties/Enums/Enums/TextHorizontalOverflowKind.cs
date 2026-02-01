namespace DocumentModel.Drawings;
/// <summary>
///   Text Horizontal Overflow Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextHorizontalOverflowValues))]
public enum TextHorizontalOverflowKind
{
  /// <summary>
  ///   Text Horizontal Overflow Enum ( Overflow ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextHorizontalOverflowValues.Overflow))]
  Overflow,
  /// <summary>
  ///   Text Horizontal Overflow Enum ( Clip ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextHorizontalOverflowValues.Clip))]
  Clip
}