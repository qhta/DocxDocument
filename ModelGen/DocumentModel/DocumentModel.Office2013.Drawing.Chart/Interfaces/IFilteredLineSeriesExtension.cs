namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ILineChartSeries))]
public interface IFilteredLineSeriesExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.ILineChartSeries? LineChartSeries { get ; set; }
  
}
