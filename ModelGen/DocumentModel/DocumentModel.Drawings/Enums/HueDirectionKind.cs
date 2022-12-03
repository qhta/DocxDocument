namespace DocumentModel.Drawings;

/// <summary>
/// Hue Direction
/// </summary>
public enum HueDirectionKind
{
  /// <summary>
  /// Clockwise Hue Direction.
  /// </summary>
  [XmlEnum("cw")]
  Clockwise,
  
  /// <summary>
  /// Counterclockwise Hue Direction.
  /// </summary>
  [XmlEnum("ccw")]
  Counterclockwise,
  
}
