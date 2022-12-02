namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Member.
/// </summary>
public interface IGroupMember // : DocumentModel.ITypedOpenXmlLeafElement
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
