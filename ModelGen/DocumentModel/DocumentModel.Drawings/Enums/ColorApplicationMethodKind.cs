namespace DocumentModel.Drawings;

/// <summary>
/// Color Application Method Type
/// </summary>
public enum ColorApplicationMethodKind
{
  /// <summary>
  /// Span.
  /// </summary>
  [XmlEnum("span")]
  Span,
  
  /// <summary>
  /// Cycle.
  /// </summary>
  [XmlEnum("cycle")]
  Cycle,
  
  /// <summary>
  /// Repeat.
  /// </summary>
  [XmlEnum("repeat")]
  Repeat,
  
}
