namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public class FilteredLineSeriesExtensionImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>, FilteredLineSeriesExtension
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  public LineChartSeries2? LineChartSeries
  {
    get;
    set;
  }
  
}
