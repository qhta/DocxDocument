namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the RadarChartExtension Class.
/// </summary>
public record RadarChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredRadarSeries? FilteredRadarSeries { get; set; }
}