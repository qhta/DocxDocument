namespace DocumentModel.Drawings;

/// <summary>
/// Path Shade Type
/// </summary>
public enum PathShadeKind
{
  /// <summary>
  /// Shape.
  /// </summary>
  [XmlEnum("shape")]
  Shape,
  
  /// <summary>
  /// Circle.
  /// </summary>
  [XmlEnum("circle")]
  Circle,
  
  /// <summary>
  /// Rectangle.
  /// </summary>
  [XmlEnum("rect")]
  Rectangle,
  
}
