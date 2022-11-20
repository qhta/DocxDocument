namespace DocumentModel.Drawing;

/// <summary>
/// Path Shade Type
/// </summary>
public enum PathShadeValues
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
