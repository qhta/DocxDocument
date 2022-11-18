namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Items.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPageItem))]
public interface IPage // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Page Item String Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
