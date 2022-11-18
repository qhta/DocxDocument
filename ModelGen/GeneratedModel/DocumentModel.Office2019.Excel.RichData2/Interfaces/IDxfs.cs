namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the Dxfs Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDifferentialFormat))]
public interface IDxfs // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
