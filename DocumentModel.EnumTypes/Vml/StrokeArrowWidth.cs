namespace DocumentModel.Vml;
/// <summary>
///   Stroke Arrowhead Width
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues))]
public enum StrokeArrowWidth
{
  /// <summary>
  ///   Narrow Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues.Narrow))]
  Narrow,
  /// <summary>
  ///   Medium Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues.Medium))]
  Medium,
  /// <summary>
  ///   Wide Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues.Wide))]
  Wide
}