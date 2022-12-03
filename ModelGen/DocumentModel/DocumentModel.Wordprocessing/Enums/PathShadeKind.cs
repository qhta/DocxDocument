namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PathShadeTypeValues enumeration.
/// </summary>
public enum PathShadeKind
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
