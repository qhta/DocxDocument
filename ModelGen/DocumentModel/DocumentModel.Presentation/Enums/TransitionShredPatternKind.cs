namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TransitionShredPatternValues enumeration.
/// </summary>
public enum TransitionShredPatternKind
{
  /// <summary>
  /// strip.
  /// </summary>
  [XmlEnum("strip")]
  Strip,
  
  /// <summary>
  /// rectangle.
  /// </summary>
  [XmlEnum("rectangle")]
  Rectangle,
  
}
