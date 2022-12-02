namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group.
/// </summary>
public interface IGroup // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Unique Group Name
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// Group Caption
  /// </summary>
  public String? Caption { get ; set; }
  
  /// <summary>
  /// Parent Unique Name
  /// </summary>
  public String? UniqueParent { get ; set; }
  
  /// <summary>
  /// Group Id
  /// </summary>
  public Int32? Id { get ; set; }
  
  /// <summary>
  /// OLAP Group Members.
  /// </summary>
  public IGroupMembers? GroupMembers { get ; set; }
  
}
