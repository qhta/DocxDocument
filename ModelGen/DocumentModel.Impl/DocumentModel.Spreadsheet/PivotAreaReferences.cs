namespace DocumentModel.Spreadsheet;

/// <summary>
/// References.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotAreaReference))]
public class PivotAreaReferences: IPivotAreaReferences
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
