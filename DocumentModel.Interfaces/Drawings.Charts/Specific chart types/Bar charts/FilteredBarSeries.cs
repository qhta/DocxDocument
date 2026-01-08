namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered bar series for a chart, containing a reference to a bar chart series.
/// </summary>
public interface FilteredBarSeries
{
  /// <summary>
  ///   Bar chart series associated with the filtered bar series.
  /// </summary>
  public BarChartSeries3 BarChartSeries { get; set; }
}