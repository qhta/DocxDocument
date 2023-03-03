namespace DocumentModel.Vml;

/// <summary>
///   Extrusion Rendering Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ExtrusionRenderKind
{
  /// <summary>
  ///   Solid.
  /// </summary>
  Solid,

  /// <summary>
  ///   Wireframe.
  /// </summary>
  WireFrame,

  /// <summary>
  ///   Bounding Cube.
  /// </summary>
  BoundingCube
}