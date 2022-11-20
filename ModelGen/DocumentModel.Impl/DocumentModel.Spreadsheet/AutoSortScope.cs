namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoSort Scope.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotArea))]
public class AutoSortScope: IAutoSortScope
{
  /// <summary>
  /// Auto Sort Scope.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea
  {
    get;
    set;
  }
  
}
