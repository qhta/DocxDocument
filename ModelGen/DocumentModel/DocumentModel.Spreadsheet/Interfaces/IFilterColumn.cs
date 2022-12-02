namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FilterColumn Class.
/// </summary>
public interface IFilterColumn // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Filter Column Data
  /// </summary>
  public UInt32? ColumnId { get ; set; }
  
  /// <summary>
  /// Hidden AutoFilter Button
  /// </summary>
  public Boolean? HiddenButton { get ; set; }
  
  /// <summary>
  /// Show Filter Button
  /// </summary>
  public Boolean? ShowButton { get ; set; }
  
  /// <summary>
  /// Filter Criteria.
  /// </summary>
  public IFilters? Filters { get ; set; }
  
  /// <summary>
  /// Top 10.
  /// </summary>
  public ITop10? Top10 { get ; set; }
  
  /// <summary>
  /// CustomFilters14.
  /// </summary>
  public ICustomFilters? CustomFilters14 { get ; set; }
  
  /// <summary>
  /// Custom Filters.
  /// </summary>
  public ICustomFilters? CustomFilters { get ; set; }
  
  /// <summary>
  /// Dynamic Filter.
  /// </summary>
  public IDynamicFilter? DynamicFilter { get ; set; }
  
  /// <summary>
  /// Color Filter Criteria.
  /// </summary>
  public IColorFilter? ColorFilter { get ; set; }
  
  /// <summary>
  /// IconFilter14.
  /// </summary>
  public IIconFilter? IconFilter14 { get ; set; }
  
  /// <summary>
  /// Icon Filter.
  /// </summary>
  public IIconFilter? IconFilter { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
