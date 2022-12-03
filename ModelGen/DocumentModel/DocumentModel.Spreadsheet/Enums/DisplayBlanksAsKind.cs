namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DisplayBlanksAsValues enumeration.
/// </summary>
public enum DisplayBlanksAsKind
{
  /// <summary>
  /// span.
  /// </summary>
  [XmlEnum("span")]
  Span,
  
  /// <summary>
  /// gap.
  /// </summary>
  [XmlEnum("gap")]
  Gap,
  
  /// <summary>
  /// zero.
  /// </summary>
  [XmlEnum("zero")]
  Zero,
  
}
