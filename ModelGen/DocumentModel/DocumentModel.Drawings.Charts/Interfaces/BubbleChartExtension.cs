namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public interface BubbleChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredBubbleSeries? FilteredBubbleSeries { get ; set; }
  
}
