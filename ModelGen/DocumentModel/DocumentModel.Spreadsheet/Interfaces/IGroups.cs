namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Level Groups.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroup))]
public interface IGroups // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Level Group Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
