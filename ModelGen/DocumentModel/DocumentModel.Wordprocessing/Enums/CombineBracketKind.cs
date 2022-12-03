namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CombineBracketValues enumeration.
/// </summary>
public enum CombineBracketKind
{
  /// <summary>
  /// No Enclosing Brackets.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Round Brackets.
  /// </summary>
  [XmlEnum("round")]
  Round,
  
  /// <summary>
  /// Square Brackets.
  /// </summary>
  [XmlEnum("square")]
  Square,
  
  /// <summary>
  /// Angle Brackets.
  /// </summary>
  [XmlEnum("angle")]
  Angle,
  
  /// <summary>
  /// Curly Brackets.
  /// </summary>
  [XmlEnum("curly")]
  Curly,
  
}
