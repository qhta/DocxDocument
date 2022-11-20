namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort By Tuple.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITuple))]
public class SortByTuple: ISortByTuple
{
  /// <summary>
  /// Member Name Count
  /// </summary>
  public uint? MemberNameCount
  {
    get;
    set;
  }
  
}
