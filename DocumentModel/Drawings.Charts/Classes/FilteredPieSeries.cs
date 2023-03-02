namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredPieSeries Class.
/// </summary>
public record FilteredPieSeries
{
  /// <summary>
  ///   PieChartSeries.
  /// </summary>
  public PieChartSeries3? PieChartSeries { get; set; }
}