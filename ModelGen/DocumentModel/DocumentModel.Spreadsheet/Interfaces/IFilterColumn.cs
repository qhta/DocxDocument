namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoFilter Column.
/// </summary>
public interface IFilterColumn // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Filter Column Data
  /// </summary>
  public System.UInt32? ColumnId { get ; set; }
  
  /// <summary>
  /// Hidden AutoFilter Button
  /// </summary>
  public System.Boolean? HiddenButton { get ; set; }
  
  /// <summary>
  /// Show Filter Button
  /// </summary>
  public System.Boolean? ShowButton { get ; set; }
  
  /// <summary>
  /// Filter Criteria.
  /// </summary>
  public DocumentModel.Spreadsheet.IFilters? Filters { get ; set; }
  
  /// <summary>
  /// Top 10.
  /// </summary>
  public DocumentModel.Spreadsheet.ITop10? Top10 { get ; set; }
  
  /// <summary>
  /// CustomFilters14, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Excel.ICustomFilters? CustomFilters14 { get ; set; }
  
  /// <summary>
  /// Custom Filters.
  /// </summary>
  public DocumentModel.Spreadsheet.ICustomFilters? CustomFilters { get ; set; }
  
  /// <summary>
  /// Dynamic Filter.
  /// </summary>
  public DocumentModel.Spreadsheet.IDynamicFilter? DynamicFilter { get ; set; }
  
  /// <summary>
  /// Color Filter Criteria.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorFilter? ColorFilter { get ; set; }
  
  /// <summary>
  /// IconFilter14, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Excel.IIconFilter? IconFilter14 { get ; set; }
  
  /// <summary>
  /// Icon Filter.
  /// </summary>
  public DocumentModel.Spreadsheet.IIconFilter? IconFilter { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
