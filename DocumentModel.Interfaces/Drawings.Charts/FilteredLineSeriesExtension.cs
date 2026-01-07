namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredLineSeriesExtension Class.
/// </summary>
public interface FilteredLineSeriesExtension: Extension
{
  /// <summary>
  ///   LineChartSeries.
  /// </summary>
  public LineChartSeries3? LineChartSeries { get; set; }
}