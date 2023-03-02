namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredBubbleSeries Class.
/// </summary>
public record FilteredBubbleSeries
{
  /// <summary>
  ///   BubbleChartSeries.
  /// </summary>
  public BubbleChartSeries3? BubbleChartSeries { get; set; }
}