namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Member.
/// </summary>
public interface IGroupMember // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Group Member Unique Name
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// Group
  /// </summary>
  public System.Boolean? Group { get ; set; }
  
}
