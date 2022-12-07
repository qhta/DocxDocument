namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
public class FilteredBubbleSeriesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>, FilteredBubbleSeries
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  public BubbleChartSeries2? BubbleChartSeries
  {
    get;
    set;
  }
  
}
