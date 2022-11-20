namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IBubbleChartSeries))]
public class FilteredBubbleSeries: IFilteredBubbleSeries
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IBubbleChartSeries? BubbleChartSeries
  {
    get;
    set;
  }
  
}
