namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroupMembers))]
public interface IGroup // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Unique Group Name
  /// </summary>
  public string? UniqueName { get ; set; }
  
  /// <summary>
  /// Group Caption
  /// </summary>
  public string? Caption { get ; set; }
  
  /// <summary>
  /// Parent Unique Name
  /// </summary>
  public string? UniqueParent { get ; set; }
  
  /// <summary>
  /// Group Id
  /// </summary>
  public int? Id { get ; set; }
  
  /// <summary>
  /// OLAP Group Members.
  /// </summary>
  public IGroupMembers? GroupMembers { get ; set; }
  
}
