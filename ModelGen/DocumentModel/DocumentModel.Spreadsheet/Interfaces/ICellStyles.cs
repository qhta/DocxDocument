namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellStyles Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICellStyle))]
public interface ICellStyles // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
