namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NsvFilter Class.
/// </summary>
public interface NsvFilter // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// filterId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? FilterId { get ; set; }
  
  /// <summary>
  /// ref, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Ref { get ; set; }
  
  /// <summary>
  /// tableId, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? TableId { get ; set; }
  
  public Collection<ColumnFilter>? ColumnFilters { get ; set; }
  
  public SortRules? SortRules { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
