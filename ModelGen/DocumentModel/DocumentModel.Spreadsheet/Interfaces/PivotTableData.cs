namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableData Class.
/// </summary>
public interface PivotTableData // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// rowCount, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? RowCount { get ; set; }
  
  /// <summary>
  /// columnCount, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? ColumnCount { get ; set; }
  
  /// <summary>
  /// cacheId, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? CacheId { get ; set; }
  
  public Collection<PivotRow>? PivotRows { get ; set; }
  
}
