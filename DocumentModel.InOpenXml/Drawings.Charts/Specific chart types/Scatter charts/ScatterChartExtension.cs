namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a scatter chart, providing additional series filtering capabilities.
/// </summary>
public class ScatterChartExtension : Extension
{
  /// <summary>
  ///   Filtered scatter series for the chart extension.
  /// </summary>
  public FilteredScatterSeries? FilteredScatterSeries { get; set; }
}