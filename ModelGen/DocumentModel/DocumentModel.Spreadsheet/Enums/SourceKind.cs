namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Type
/// </summary>
public enum SourceKind
{
  /// <summary>
  /// Worksheet.
  /// </summary>
  Worksheet,
  
  /// <summary>
  /// External.
  /// </summary>
  External,
  
  /// <summary>
  /// Consolidation Ranges.
  /// </summary>
  Consolidation,
  
  /// <summary>
  /// Scenario Summary Report.
  /// </summary>
  Scenario,
  
}
