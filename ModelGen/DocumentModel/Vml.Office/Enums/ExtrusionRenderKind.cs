namespace DocumentModel.Vml.Office;


/// <summary>
///   Extrusion Rendering Types
/// </summary>
public enum ExtrusionRenderKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;solid&quot;.
  /// </summary>
  [EnumString("solid")]
  Solid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wireFrame&quot;.
  /// </summary>
  [EnumString("wireFrame")]
  WireFrame,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;boundingCube&quot;.
  /// </summary>
  [EnumString("boundingCube")]
  BoundingCube,
  
}
