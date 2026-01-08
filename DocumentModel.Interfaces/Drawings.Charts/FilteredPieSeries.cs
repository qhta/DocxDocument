namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered pie series for a chart, containing a reference to a pie chart series.
/// </summary>
public interface FilteredPieSeries
{
  /// <summary>
  ///   Pie chart series associated with the filtered pie series.
  /// </summary>
  public PieChartSeries3 PieChartSeries { get; set; }
}