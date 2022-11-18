namespace DocumentModel.Math;

/// <summary>
/// Defines the JustificationValues enumeration.
/// </summary>
public enum Justification
{
  /// <summary>
  /// Left Justification.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Right.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// Center (Equation).
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Centered as Group (Equations).
  /// </summary>
  [XmlEnum("centerGroup")]
  CenterGroup,
  
}
