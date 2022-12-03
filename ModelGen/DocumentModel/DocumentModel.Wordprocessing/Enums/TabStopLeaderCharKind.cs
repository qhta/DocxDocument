namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TabStopLeaderCharValues enumeration.
/// </summary>
public enum TabStopLeaderCharKind
{
  /// <summary>
  /// No tab stop leader.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Dotted leader line.
  /// </summary>
  [XmlEnum("dot")]
  Dot,
  
  /// <summary>
  /// Dashed tab stop leader line.
  /// </summary>
  [XmlEnum("hyphen")]
  Hyphen,
  
  /// <summary>
  /// Solid leader line.
  /// </summary>
  [XmlEnum("underscore")]
  Underscore,
  
  /// <summary>
  /// Heavy solid leader line.
  /// </summary>
  [XmlEnum("heavy")]
  Heavy,
  
  /// <summary>
  /// Middle dot leader line.
  /// </summary>
  [XmlEnum("middleDot")]
  MiddleDot,
  
}
