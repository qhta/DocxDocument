namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Member.
/// </summary>
public interface IGroupMember // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Group Member Unique Name
  /// </summary>
  public string? UniqueName { get ; set; }
  
  /// <summary>
  /// Group
  /// </summary>
  public bool? Group { get ; set; }
  
}
