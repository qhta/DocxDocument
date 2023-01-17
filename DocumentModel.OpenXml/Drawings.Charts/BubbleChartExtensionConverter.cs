namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public static class BubbleChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.FilteredBubbleSeries? GetFilteredBubbleSeries(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredBubbleSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredBubbleSeries(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredBubbleSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredBubbleSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBubbleSeries = GetFilteredBubbleSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredBubbleSeries(openXmlElement, value?.FilteredBubbleSeries);
      return openXmlElement;
    }
    return default;
  }
}
