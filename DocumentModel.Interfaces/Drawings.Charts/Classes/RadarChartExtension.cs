namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the RadarChartExtension Class.
/// </summary>
public interface RadarChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredRadarSeries? FilteredRadarSeries { get; set; }
}