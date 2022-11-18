namespace DocumentModel.Presentation;

/// <summary>
/// Time List Animate Color Direction
/// </summary>
public enum AnimateColorDirection
{
  /// <summary>
  /// Direction Enum ( Clockwise ).
  /// </summary>
  [XmlEnum("cw")]
  Clockwise,
  
  /// <summary>
  /// Counter-Clockwise.
  /// </summary>
  [XmlEnum("ccw")]
  CounterClockwise,
  
}
