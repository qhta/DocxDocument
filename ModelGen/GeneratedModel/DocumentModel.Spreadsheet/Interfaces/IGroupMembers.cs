namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Members.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroupMember))]
public interface IGroupMembers // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Member Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
