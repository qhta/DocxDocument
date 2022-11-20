namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotAreas Class.
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
