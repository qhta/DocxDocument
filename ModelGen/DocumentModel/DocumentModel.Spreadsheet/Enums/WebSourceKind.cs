namespace DocumentModel.Spreadsheet;

/// <summary>
/// Web Source Type
/// </summary>
public enum WebSourceKind
{
  /// <summary>
  /// All Sheet Content.
  /// </summary>
  Sheet,
  
  /// <summary>
  /// Print Area.
  /// </summary>
  PrintArea,
  
  /// <summary>
  /// AutoFilter.
  /// </summary>
  AutoFilter,
  
  /// <summary>
  /// Range.
  /// </summary>
  Range,
  
  /// <summary>
  /// Chart.
  /// </summary>
  Chart,
  
  /// <summary>
  /// PivotTable.
  /// </summary>
  PivotTable,
  
  /// <summary>
  /// QueryTable.
  /// </summary>
  Query,
  
  /// <summary>
  /// Label.
  /// </summary>
  Label,
  
}
