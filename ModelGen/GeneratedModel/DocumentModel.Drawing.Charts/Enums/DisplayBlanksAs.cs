namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Display Blanks As
/// </summary>
public enum DisplayBlanksAs
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
