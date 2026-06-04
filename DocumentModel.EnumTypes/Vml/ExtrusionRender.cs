namespace DocumentModel.Vml;
/// <summary>
///   Extrusion Rendering Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues))]
public enum ExtrusionRender
{
  /// <summary>
  ///   Solid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues.Solid))]
  Solid,
  /// <summary>
  ///   Wireframe.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues.WireFrame))]
  WireFrame,
  /// <summary>
  ///   Bounding Cube.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues.BoundingCube))]
  BoundingCube
}