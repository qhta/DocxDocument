namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilters Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotFilter))]
public class PivotFilters: IPivotFilters
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
