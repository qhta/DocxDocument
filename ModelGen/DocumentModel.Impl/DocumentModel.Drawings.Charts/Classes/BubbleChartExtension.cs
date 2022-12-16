namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public class BubbleChartExtensionImpl: ModelElementImpl, BubbleChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BubbleChartExtensionImpl(): base() {}
  
  public BubbleChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Charts.FilteredBubbleSeries? FilteredBubbleSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredBubbleSeriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredBubbleSeriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
