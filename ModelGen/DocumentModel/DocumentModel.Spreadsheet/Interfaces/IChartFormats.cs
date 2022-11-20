namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ChartFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IChartFormat))]
public interface IChartFormats // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
