namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableRowAlignmentValues enumeration.
/// </summary>
public enum TableRowAlignmentKind
{
  /// <summary>
  /// left.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// right.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
}
