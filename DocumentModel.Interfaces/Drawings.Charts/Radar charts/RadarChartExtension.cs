namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the RadarChartExtension Class.
/// </summary>
public interface RadarChartExtension: Extension
{
  public FilteredRadarSeries? FilteredRadarSeries { get; set; }
}