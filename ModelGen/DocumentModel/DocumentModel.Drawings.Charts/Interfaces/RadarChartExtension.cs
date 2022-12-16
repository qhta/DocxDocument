namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public interface RadarChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.Charts.FilteredRadarSeries? FilteredRadarSeries { get ; set; }
  
}
