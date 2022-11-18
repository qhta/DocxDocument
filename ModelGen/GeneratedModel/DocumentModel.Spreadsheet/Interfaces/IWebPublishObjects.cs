namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebPublishObjects Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IWebPublishObject))]
public interface IWebPublishObjects // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
