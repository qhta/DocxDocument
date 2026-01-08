namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered scatter series for a chart, containing a reference to a scatter chart series.
/// </summary>
public interface FilteredScatterSeries
{
  /// <summary>
  ///   Scatter chart series associated with the filtered scatter series.
  /// </summary>
  public ScatterChartSeries3 ScatterChartSeries { get; set; }
}