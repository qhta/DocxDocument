namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the RadarChartExtension Class.
/// </summary>
public class RadarChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredRadarSeries? FilteredRadarSeries { get; set; }
}