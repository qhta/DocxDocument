namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort State for Auto Filter.
/// </summary>
public interface ISortState // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public Collection<ISortCondition>? SortConditions { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
