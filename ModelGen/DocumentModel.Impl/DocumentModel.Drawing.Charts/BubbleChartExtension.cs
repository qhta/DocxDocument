namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredBubbleSeries))]
public class BubbleChartExtension: IBubbleChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
