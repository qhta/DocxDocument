namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a bubble chart, providing additional series filtering capabilities.
/// </summary>
public interface BubbleChartExtension : Extension
{
  /// <summary>
  ///   Filtered bubble series for the chart extension.
  /// </summary>
  public FilteredBubbleSeries? FilteredBubbleSeries { get; set; }
}