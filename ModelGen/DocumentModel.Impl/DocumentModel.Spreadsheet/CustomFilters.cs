namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Filters.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICustomFilter))]
public class CustomFilters: ICustomFilters
{
  /// <summary>
  /// And
  /// </summary>
  public bool? And
  {
    get;
    set;
  }
  
}
