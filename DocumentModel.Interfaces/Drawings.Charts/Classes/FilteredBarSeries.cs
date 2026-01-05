namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredBarSeries Class.
/// </summary>
public interface FilteredBarSeries:
{
  /// <summary>
  ///   BarChartSeries.
  /// </summary>
  public BarChartSeries3? BarChartSeries { get; set; }
}