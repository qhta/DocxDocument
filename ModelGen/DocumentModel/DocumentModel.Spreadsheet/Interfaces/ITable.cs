namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table.
/// </summary>
public interface ITable // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Table Id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Table Name
  /// </summary>
  public System.String? DisplayName { get ; set; }
  
  /// <summary>
  /// Table Comment
  /// </summary>
  public System.String? Comment { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// Table Type
  /// </summary>
  public DocumentModel.Spreadsheet.TableKind? TableType { get ; set; }
  
  /// <summary>
  /// Header Row Count
  /// </summary>
  public System.UInt32? HeaderRowCount { get ; set; }
  
  /// <summary>
  /// Insert Row Showing
  /// </summary>
  public System.Boolean? InsertRow { get ; set; }
  
  /// <summary>
  /// Insert Row Shift
  /// </summary>
  public System.Boolean? InsertRowShift { get ; set; }
  
  /// <summary>
  /// Totals Row Count
  /// </summary>
  public System.UInt32? TotalsRowCount { get ; set; }
  
  /// <summary>
  /// Totals Row Shown
  /// </summary>
  public System.Boolean? TotalsRowShown { get ; set; }
  
  /// <summary>
  /// Published
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
  /// <summary>
  /// Header Row Format Id
  /// </summary>
  public System.UInt32? HeaderRowFormatId { get ; set; }
  
  /// <summary>
  /// Data Area Format Id
  /// </summary>
  public System.UInt32? DataFormatId { get ; set; }
  
  /// <summary>
  /// Totals Row Format Id
  /// </summary>
  public System.UInt32? TotalsRowFormatId { get ; set; }
  
  /// <summary>
  /// Header Row Border Format Id
  /// </summary>
  public System.UInt32? HeaderRowBorderFormatId { get ; set; }
  
  /// <summary>
  /// Table Border Format Id
  /// </summary>
  public System.UInt32? BorderFormatId { get ; set; }
  
  /// <summary>
  /// Totals Row Border Format Id
  /// </summary>
  public System.UInt32? TotalsRowBorderFormatId { get ; set; }
  
  /// <summary>
  /// Header Row Style
  /// </summary>
  public System.String? HeaderRowCellStyle { get ; set; }
  
  /// <summary>
  /// Data Style Name
  /// </summary>
  public System.String? DataCellStyle { get ; set; }
  
  /// <summary>
  /// Totals Row Style
  /// </summary>
  public System.String? TotalsRowCellStyle { get ; set; }
  
  /// <summary>
  /// Connection ID
  /// </summary>
  public System.UInt32? ConnectionId { get ; set; }
  
  /// <summary>
  /// Table AutoFilter.
  /// </summary>
  public DocumentModel.Spreadsheet.IAutoFilter? AutoFilter { get ; set; }
  
  /// <summary>
  /// Sort State.
  /// </summary>
  public DocumentModel.Spreadsheet.ISortState? SortState { get ; set; }
  
  /// <summary>
  /// Table Columns.
  /// </summary>
  public DocumentModel.Spreadsheet.ITableColumns? TableColumns { get ; set; }
  
  /// <summary>
  /// Table Style.
  /// </summary>
  public DocumentModel.Spreadsheet.ITableStyleInfo? TableStyleInfo { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TableExtensionList { get ; set; }
  
}
