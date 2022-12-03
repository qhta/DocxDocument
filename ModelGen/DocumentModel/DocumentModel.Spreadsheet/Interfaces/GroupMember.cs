namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Member.
/// </summary>
public interface GroupMember // : System.Boolean
{
  /// <summary>
  /// Group Member Unique Name
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// Group
  /// </summary>
  public Boolean? Group { get ; set; }
  
}
