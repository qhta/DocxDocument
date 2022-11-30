namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ChartFormats Class.
/// </summary>
public interface IChartFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IChartFormat>? ChartFormats { get ; set; }
  
}
