namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public class FilteredAreaSeriesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>, FilteredAreaSeries
{
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  public AreaChartSeries2? AreaChartSeries
  {
    get;
    set;
  }
  
}
