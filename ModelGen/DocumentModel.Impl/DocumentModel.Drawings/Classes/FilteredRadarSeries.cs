namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredRadarSeries Class.
/// </summary>
public class FilteredRadarSeriesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries>, FilteredRadarSeries
{
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  public RadarChartSeries2? RadarChartSeries
  {
    get;
    set;
  }
  
}
