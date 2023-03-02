namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredScatterSeries Class.
/// </summary>
public record FilteredScatterSeries
{
  /// <summary>
  ///   ScatterChartSeries.
  /// </summary>
  public ScatterChartSeries3? ScatterChartSeries { get; set; }
}