namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Application Method Type
/// </summary>
public enum ColorApplicationMethod
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
