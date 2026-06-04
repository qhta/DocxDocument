namespace DocumentModel.Vml;
/// <summary>
///   Stroke End Cap Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.StrokeEndCapValues))]
public enum StrokeEndCap
{
  /// <summary>
  ///   Flat End.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeEndCapValues.Flat))]
  Flat,
  /// <summary>
  ///   Square End.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeEndCapValues.Square))]
  Square,
  /// <summary>
  ///   Round End.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeEndCapValues.Round))]
  Round
}