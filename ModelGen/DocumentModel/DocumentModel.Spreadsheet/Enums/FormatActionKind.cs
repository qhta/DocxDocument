namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Format Types
/// </summary>
public enum FormatActionKind
{
  /// <summary>
  /// Blank.
  /// </summary>
  [XmlEnum("blank")]
  Blank,
  
  /// <summary>
  /// Formatting.
  /// </summary>
  [XmlEnum("formatting")]
  Formatting,
  
}
