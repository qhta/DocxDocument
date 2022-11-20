namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoFilter Column.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColorFilter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICustomFilters))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDynamicFilter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFilters))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IIconFilter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITop10))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ICustomFilters))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IIconFilter))]
public class FilterColumn: IFilterColumn
{
  /// <summary>
  /// Filter Column Data
  /// </summary>
  public uint? ColumnId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hidden AutoFilter Button
  /// </summary>
  public bool? HiddenButton
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Filter Button
  /// </summary>
  public bool? ShowButton
  {
    get;
    set;
  }
  
  /// <summary>
  /// Filter Criteria.
  /// </summary>
  public IFilters? Filters
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top 10.
  /// </summary>
  public ITop10? Top10
  {
    get;
    set;
  }
  
  /// <summary>
  /// CustomFilters14, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Excel.ICustomFilters? CustomFilters14
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Filters.
  /// </summary>
  public DocumentModel.Spreadsheet.ICustomFilters? CustomFilters
  {
    get;
    set;
  }
  
  /// <summary>
  /// Dynamic Filter.
  /// </summary>
  public IDynamicFilter? DynamicFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color Filter Criteria.
  /// </summary>
  public IColorFilter? ColorFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// IconFilter14, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Excel.IIconFilter? IconFilter14
  {
    get;
    set;
  }
  
  /// <summary>
  /// Icon Filter.
  /// </summary>
  public DocumentModel.Spreadsheet.IIconFilter? IconFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
