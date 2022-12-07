namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public class FilteredPieSeriesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>, FilteredPieSeries
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public PieChartSeries2? PieChartSeries
  {
    get;
    set;
  }
  
}
