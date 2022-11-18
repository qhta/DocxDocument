namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DifferentialFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDifferentialFormat))]
public interface IDifferentialFormats // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
