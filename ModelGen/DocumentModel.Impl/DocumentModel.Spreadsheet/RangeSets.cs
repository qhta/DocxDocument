namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Sets.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRangeSet))]
public class RangeSets: IRangeSets
{
  /// <summary>
  /// Reference and Page Item Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
