namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Members.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroupMember))]
public class GroupMembers: IGroupMembers
{
  /// <summary>
  /// Group Member Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
