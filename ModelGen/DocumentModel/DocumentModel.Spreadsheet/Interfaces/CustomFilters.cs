namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Filters.
/// </summary>
public interface CustomFilters // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// And
  /// </summary>
  public Boolean? And { get ; set; }
  
  public Collection<CustomFilter>? CustomFilters { get ; set; }
  
}
