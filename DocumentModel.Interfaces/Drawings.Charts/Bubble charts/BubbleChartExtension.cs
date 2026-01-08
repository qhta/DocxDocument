namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleChartExtension Class.
/// </summary>
public interface BubbleChartExtension: Extension
{
  public FilteredBubbleSeries? FilteredBubbleSeries { get; set; }
}