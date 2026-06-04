namespace DocumentModel.Vml;
/// <summary>
///   Extrusion Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.ExtrusionValues))]
public enum ExtrusionType
{
  /// <summary>
  ///   Perspective Projection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ExtrusionValues.Perspective))]
  Perspective,
  /// <summary>
  ///   Parallel Projection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ExtrusionValues.Parallel))]
  Parallel
}