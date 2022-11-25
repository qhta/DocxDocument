namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotTableData Class.
/// </summary>
public interface IPivotTableData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// rowCount, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? RowCount { get ; set; }
  
  /// <summary>
  /// columnCount, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? ColumnCount { get ; set; }
  
  /// <summary>
  /// cacheId, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? CacheId { get ; set; }
  
}
