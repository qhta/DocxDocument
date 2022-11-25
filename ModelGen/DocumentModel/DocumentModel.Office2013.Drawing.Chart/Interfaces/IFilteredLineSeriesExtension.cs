namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public interface IFilteredLineSeriesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.ILineChartSeries? LineChartSeries { get ; set; }
  
}
