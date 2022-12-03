namespace DocumentModel.Drawings;

/// <summary>
/// Axis Position
/// </summary>
public enum AxisPositionKind
{
  /// <summary>
  /// Bottom.
  /// </summary>
  [XmlEnum("b")]
  Bottom,
  
  /// <summary>
  /// Left.
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Right.
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Top.
  /// </summary>
  [XmlEnum("t")]
  Top,
  
}
