namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DisplayBlanksAsValues enumeration.
/// </summary>
public enum DisplayBlanksAsValues
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
