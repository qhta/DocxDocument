namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FilterColumn Class.
/// </summary>
public interface FilterColumn // : DocumentModel.BaseTypes.ModelElement
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
  public Filters? Filters { get ; set; }
  
  /// <summary>
  /// Top 10.
  /// </summary>
  public Top10? Top10 { get ; set; }
  
  /// <summary>
  /// CustomFilters14.
  /// </summary>
  public CustomFilters? CustomFilters14 { get ; set; }
  
  /// <summary>
  /// Custom Filters.
  /// </summary>
  public CustomFilters? CustomFilters { get ; set; }
  
  /// <summary>
  /// Dynamic Filter.
  /// </summary>
  public DynamicFilter? DynamicFilter { get ; set; }
  
  /// <summary>
  /// Color Filter Criteria.
  /// </summary>
  public ColorFilter? ColorFilter { get ; set; }
  
  /// <summary>
  /// IconFilter14.
  /// </summary>
  public IconFilter? IconFilter14 { get ; set; }
  
  /// <summary>
  /// Icon Filter.
  /// </summary>
  public IconFilter? IconFilter { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
