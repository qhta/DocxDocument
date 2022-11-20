namespace DocumentModel.Spreadsheet;

/// <summary>
/// Tuples.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITuple))]
public class Tuples: ITuples
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
