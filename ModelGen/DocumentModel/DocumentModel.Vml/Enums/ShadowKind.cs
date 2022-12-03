namespace DocumentModel.Vml;

/// <summary>
/// Shadow Type
/// </summary>
public enum ShadowKind
{
  /// <summary>
  /// Single Shadow.
  /// </summary>
  [XmlEnum("single")]
  Single,
  
  /// <summary>
  /// Double Shadow.
  /// </summary>
  [XmlEnum("double")]
  Double,
  
  /// <summary>
  /// Embossed Shadow.
  /// </summary>
  [XmlEnum("emboss")]
  Emboss,
  
  /// <summary>
  /// Perspective Shadow.
  /// </summary>
  [XmlEnum("perspective")]
  Perspective,
  
  /// <summary>
  /// shapeRelative.
  /// </summary>
  [XmlEnum("shapeRelative")]
  ShapeRelative,
  
  /// <summary>
  /// drawingRelative.
  /// </summary>
  [XmlEnum("drawingRelative")]
  DrawingRelative,
  
}
