namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Item Values.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPage))]
public interface IPages // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Page Item String Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
