namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Members.
/// </summary>
public interface GroupMembers // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Group Member Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<GroupMember>? GroupMembers { get ; set; }
  
}
