namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public interface RadarChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredRadarSeries? FilteredRadarSeries { get ; set; }
  
}
