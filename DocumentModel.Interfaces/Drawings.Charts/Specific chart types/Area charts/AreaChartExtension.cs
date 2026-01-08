namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for an area chart, providing additional series filtering capabilities.
/// </summary>
public interface AreaChartExtension : Extension
{
  /// <summary>
  ///   Filtered area series for the chart extension.
  /// </summary>
  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}