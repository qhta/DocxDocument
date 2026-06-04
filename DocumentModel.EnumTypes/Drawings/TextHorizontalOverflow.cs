namespace DocumentModel.Drawings;
/// <summary>
///   Text Horizontal Overflow Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues))]
public enum TextHorizontalOverflow
{
  /// <summary>
  ///   Text Horizontal Overflow Enum ( Overflow ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues.Overflow))]
  Overflow,
  /// <summary>
  ///   Text Horizontal Overflow Enum ( Clip ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues.Clip))]
  Clip
}