namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleChartExtension Class.
/// </summary>
public interface BubbleChartExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredBubbleSeries? FilteredBubbleSeries { get; set; }
}