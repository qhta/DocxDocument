namespace DocumentModel.Vml;
/// <summary>
///   Stroke Arrowhead Length
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues))]
public enum StrokeArrowLength
{
  /// <summary>
  ///   Short Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues.Short))]
  Short,
  /// <summary>
  ///   Medium Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues.Medium))]
  Medium,
  /// <summary>
  ///   Long Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues.Long))]
  Long
}