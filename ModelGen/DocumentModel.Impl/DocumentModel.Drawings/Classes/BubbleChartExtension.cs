namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public FilteredBubbleSeries? FilteredBubbleSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
