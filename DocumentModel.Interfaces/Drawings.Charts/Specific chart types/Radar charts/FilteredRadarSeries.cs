namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered radar series for a chart, containing a reference to a radar chart series.
/// </summary>
public interface FilteredRadarSeries
{
  /// <summary>
  ///   Radar chart series associated with the filtered radar series.
  /// </summary>
  public RadarChartSeries3 RadarChartSeries { get; set; }
}