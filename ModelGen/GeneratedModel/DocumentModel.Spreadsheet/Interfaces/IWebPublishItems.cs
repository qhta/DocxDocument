namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebPublishItems Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IWebPublishItem))]
public interface IWebPublishItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Web Publishing Items Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
