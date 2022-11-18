namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Format Types
/// </summary>
public enum FormatAction
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
