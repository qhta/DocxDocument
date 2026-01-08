namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered bubble series for a chart, containing a reference to a bubble chart series.
/// </summary>
public interface FilteredBubbleSeries
{
  /// <summary>
  ///   Bubble chart series associated with the filtered bubble series.
  /// </summary>
  public BubbleChartSeries3 BubbleChartSeries { get; set; }
}