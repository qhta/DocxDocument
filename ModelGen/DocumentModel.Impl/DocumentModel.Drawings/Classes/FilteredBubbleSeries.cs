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
  
  public FilteredBubbleSeriesImpl(): base() {}
  
  public FilteredBubbleSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  public BubbleChartSeries? BubbleChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
