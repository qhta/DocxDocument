namespace DocumentModel.Drawings;
/// <summary>
///   Text Vertical Overflow
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues))]
public enum TextVerticalOverflow
{
  /// <summary>
  ///   Text Overflow Enum ( Overflow ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues.Overflow))]
  Overflow,
  /// <summary>
  ///   Text Overflow Enum ( Ellipsis ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues.Ellipsis))]
  Ellipsis,
  /// <summary>
  ///   Text Overflow Enum ( Clip ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues.Clip))]
  Clip
}