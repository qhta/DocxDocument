namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public partial interface BubbleChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredBubbleSeries? FilteredBubbleSeries { get; set; }
  
}
