namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
public class FilteredBarSeriesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>, FilteredBarSeries
{
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  public BarChartSeries2? BarChartSeries
  {
    get;
    set;
  }
  
}
