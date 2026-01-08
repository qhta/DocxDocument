namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a radar chart, providing additional series filtering capabilities.
/// </summary>
public interface RadarChartExtension : Extension
{
  /// <summary>
  ///   Filtered radar series for the chart extension.
  /// </summary>
  public FilteredRadarSeries? FilteredRadarSeries { get; set; }
}