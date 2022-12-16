namespace DocumentModel.Drawings.Charts;

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
  public DocumentModel.Drawings.Charts.BubbleChartSeries3? BubbleChartSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.BubbleChartSeries3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.BubbleChartSeries3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
