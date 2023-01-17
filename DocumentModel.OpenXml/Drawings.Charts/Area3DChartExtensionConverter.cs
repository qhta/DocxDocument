namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
public static class Area3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.FilteredAreaSeries? GetFilteredAreaSeries(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredAreaSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredAreaSeries(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredAreaSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredAreaSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Area3DChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Area3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredAreaSeries = GetFilteredAreaSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Area3DChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredAreaSeries(openXmlElement, value?.FilteredAreaSeries);
      return openXmlElement;
    }
    return default;
  }
}
