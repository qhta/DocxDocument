namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Filters.
/// </summary>
public interface ICustomFilters // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// And
  /// </summary>
  public Boolean? And { get ; set; }
  
  public Collection<ICustomFilter>? CustomFilters { get ; set; }
  
}
