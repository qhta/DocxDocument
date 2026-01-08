namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a line chart, providing additional series extension capabilities.
/// </summary>
public interface LineChartExtension : Extension
{
  /// <summary>
  ///   Filtered line series extension for the chart extension.
  /// </summary>
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}