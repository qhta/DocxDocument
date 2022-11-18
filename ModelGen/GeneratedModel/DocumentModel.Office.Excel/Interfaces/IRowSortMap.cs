namespace DocumentModel.Office.Excel;

/// <summary>
/// Row Sort Map.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IRowSortMapItem))]
public interface IRowSortMap // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? Ref { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
