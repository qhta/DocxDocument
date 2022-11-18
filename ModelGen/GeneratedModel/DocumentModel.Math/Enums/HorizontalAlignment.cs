namespace DocumentModel.Math;

/// <summary>
/// Defines the HorizontalAlignmentValues enumeration.
/// </summary>
public enum HorizontalAlignment
{
  /// <summary>
  /// Left Justification.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Right.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
}
