namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Formats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFormat))]
public interface IFormats // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formats Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
