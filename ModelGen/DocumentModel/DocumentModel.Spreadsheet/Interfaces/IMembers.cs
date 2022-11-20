namespace DocumentModel.Spreadsheet;

/// <summary>
/// Members.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMember))]
public interface IMembers // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Item Count
  /// </summary>
  public uint? Count { get ; set; }
  
  /// <summary>
  /// Hierarchy Level
  /// </summary>
  public uint? Level { get ; set; }
  
}
