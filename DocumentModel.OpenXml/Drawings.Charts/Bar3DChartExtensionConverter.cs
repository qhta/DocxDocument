namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public static class Bar3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.FilteredBarSeries? GetFilteredBarSeries(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredBarSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredBarSeries(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredBarSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredBarSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Bar3DChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Bar3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Bar3DChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredBarSeries(openXmlElement, value?.FilteredBarSeries);
      return openXmlElement;
    }
    return default;
  }
}
