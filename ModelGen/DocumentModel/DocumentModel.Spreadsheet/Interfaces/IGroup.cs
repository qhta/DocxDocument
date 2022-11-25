namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group.
/// </summary>
public interface IGroup // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Unique Group Name
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// Group Caption
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// Parent Unique Name
  /// </summary>
  public System.String? UniqueParent { get ; set; }
  
  /// <summary>
  /// Group Id
  /// </summary>
  public System.Int32? Id { get ; set; }
  
  /// <summary>
  /// OLAP Group Members.
  /// </summary>
  public DocumentModel.Spreadsheet.IGroupMembers? GroupMembers { get ; set; }
  
}
