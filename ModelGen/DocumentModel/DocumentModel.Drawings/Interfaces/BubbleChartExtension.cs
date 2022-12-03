namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public interface BubbleChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredBubbleSeries? FilteredBubbleSeries { get ; set; }
  
}
