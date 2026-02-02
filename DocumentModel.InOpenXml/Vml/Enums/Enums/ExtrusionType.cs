namespace DocumentModel.Vml;
/// <summary>
///   Extrusion Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.ExtrusionValues))]
public enum ExtrusionType
{
  /// <summary>
  ///   Perspective Projection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ExtrusionValues.Perspective))]
  Perspective,
  /// <summary>
  ///   Parallel Projection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ExtrusionValues.Parallel))]
  Parallel
}