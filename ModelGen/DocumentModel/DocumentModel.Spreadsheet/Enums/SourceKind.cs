namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Type
/// </summary>
public enum SourceKind
{
  /// <summary>
  /// Worksheet.
  /// </summary>
  [XmlEnum("worksheet")]
  Worksheet,
  
  /// <summary>
  /// External.
  /// </summary>
  [XmlEnum("external")]
  External,
  
  /// <summary>
  /// Consolidation Ranges.
  /// </summary>
  [XmlEnum("consolidation")]
  Consolidation,
  
  /// <summary>
  /// Scenario Summary Report.
  /// </summary>
  [XmlEnum("scenario")]
  Scenario,
  
}
