namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
public class FilteredBubbleSeriesImpl: ModelElementImpl, FilteredBubbleSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  public BubbleChartSeries1? BubbleChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
