namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort State for Auto Filter.
/// </summary>
public interface SortState // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Sort by Columns
  /// </summary>
  public Boolean? ColumnSort { get ; set; }
  
  /// <summary>
  /// Case Sensitive
  /// </summary>
  public Boolean? CaseSensitive { get ; set; }
  
  /// <summary>
  /// Sort Method
  /// </summary>
  public SortMethodKind? SortMethod { get ; set; }
  
  /// <summary>
  /// Sort Range
  /// </summary>
  public String? Reference { get ; set; }
  
  public Collection<SortCondition>? SortConditions { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
