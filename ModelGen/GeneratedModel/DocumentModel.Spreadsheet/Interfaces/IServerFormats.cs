namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Formats.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IServerFormat))]
public interface IServerFormats // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
