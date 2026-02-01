namespace DocumentModel.Vml;
/// <summary>
///   Extrusion Rendering Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.ExtrusionRenderValues))]
public enum ExtrusionRenderKind
{
  /// <summary>
  ///   Solid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ExtrusionRenderValues.Solid))]
  Solid,
  /// <summary>
  ///   Wireframe.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ExtrusionRenderValues.WireFrame))]
  WireFrame,
  /// <summary>
  ///   Bounding Cube.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ExtrusionRenderValues.BoundingCube))]
  BoundingCube
}