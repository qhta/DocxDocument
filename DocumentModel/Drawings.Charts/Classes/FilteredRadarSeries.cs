namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredRadarSeries Class.
/// </summary>
public record FilteredRadarSeries
{
  /// <summary>
  ///   RadarChartSeries.
  /// </summary>
  public RadarChartSeries3? RadarChartSeries { get; set; }
}