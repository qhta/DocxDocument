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
  
  public DocumentModel.Drawings13.Charts.FilteredBubbleSeries? FilteredBubbleSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
