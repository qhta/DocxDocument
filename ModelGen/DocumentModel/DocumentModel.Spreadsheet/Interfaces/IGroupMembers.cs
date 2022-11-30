namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Members.
/// </summary>
public interface IGroupMembers // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Member Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IGroupMember>? GroupMembers { get ; set; }
  
}
