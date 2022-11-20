namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotTableData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotRow))]
public interface IPivotTableData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// rowCount, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? RowCount { get ; set; }
  
  /// <summary>
  /// columnCount, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? ColumnCount { get ; set; }
  
  /// <summary>
  /// cacheId, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? CacheId { get ; set; }
  
}
