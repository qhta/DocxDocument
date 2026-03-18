namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a filtered line series, containing a reference to a line chart series.
/// </summary>
public class FilteredLineSeriesExtension : Extension
{
  /// <summary>
  ///   Line chart series associated with the filtered line series extension.
  /// </summary>
  public LineChartSeries3? LineChartSeries { get; set; }
}