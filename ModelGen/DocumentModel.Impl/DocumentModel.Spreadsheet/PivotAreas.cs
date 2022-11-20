namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pivot Areas.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotArea))]
public class PivotAreas: IPivotAreas
{
  /// <summary>
  /// Pivot Area Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
