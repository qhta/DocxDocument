namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICellFormat))]
public interface ICellFormats // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
