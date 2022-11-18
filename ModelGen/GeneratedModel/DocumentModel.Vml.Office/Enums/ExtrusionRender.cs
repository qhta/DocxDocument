namespace DocumentModel.Vml.Office;

/// <summary>
/// Extrusion Rendering Types
/// </summary>
public enum ExtrusionRender
{
  /// <summary>
  /// Solid.
  /// </summary>
  [XmlEnum("solid")]
  Solid,
  
  /// <summary>
  /// Wireframe.
  /// </summary>
  [XmlEnum("wireFrame")]
  WireFrame,
  
  /// <summary>
  /// Bounding Cube.
  /// </summary>
  [XmlEnum("boundingCube")]
  BoundingCube,
  
}
