namespace DocumentModel.Spreadsheet;

/// <summary>
/// Members.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMember))]
public class Members: IMembers
{
  /// <summary>
  /// Item Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hierarchy Level
  /// </summary>
  public uint? Level
  {
    get;
    set;
  }
  
}
