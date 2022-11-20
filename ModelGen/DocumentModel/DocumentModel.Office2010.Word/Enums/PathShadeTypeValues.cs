namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the PathShadeTypeValues enumeration.
/// </summary>
public enum PathShadeTypeValues
{
  /// <summary>
  /// shape.
  /// </summary>
  [XmlEnum("shape")]
  Shape,
  
  /// <summary>
  /// circle.
  /// </summary>
  [XmlEnum("circle")]
  Circle,
  
  /// <summary>
  /// rect.
  /// </summary>
  [XmlEnum("rect")]
  Rect,
  
}
