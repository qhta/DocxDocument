namespace DocumentModel.Wordprocessing;

/// <summary>
/// Horizontal Alignment Type
/// </summary>
public enum LevelJustificationKind
{
  /// <summary>
  /// Align Left.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Align Center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Align Right.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
}
