namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
public class FilteredScatterSeriesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries>, FilteredScatterSeries
{
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  public ScatterChartSeries2? ScatterChartSeries
  {
    get;
    set;
  }
  
}
