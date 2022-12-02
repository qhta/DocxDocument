namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Members.
/// </summary>
public interface IGroupMembers // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Member Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IGroupMember>? GroupMembers { get ; set; }
  
}
