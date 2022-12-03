namespace DocumentModel.Drawings;

/// <summary>
/// Display Blanks As
/// </summary>
public enum DisplayBlanksAsKind
{
  /// <summary>
  /// Span.
  /// </summary>
  [XmlEnum("span")]
  Span,
  
  /// <summary>
  /// Gap.
  /// </summary>
  [XmlEnum("gap")]
  Gap,
  
  /// <summary>
  /// Zero.
  /// </summary>
  [XmlEnum("zero")]
  Zero,
  
}
