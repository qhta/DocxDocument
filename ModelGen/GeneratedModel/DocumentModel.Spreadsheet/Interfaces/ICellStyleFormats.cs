namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellStyleFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICellFormat))]
public interface ICellStyleFormats // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
