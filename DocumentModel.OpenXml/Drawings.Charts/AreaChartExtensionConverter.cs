namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public static class AreaChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.FilteredAreaSeries? GetFilteredAreaSeries(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredAreaSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFilteredAreaSeries(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension? openXmlElement, DocumentModel.Drawings.Charts.FilteredAreaSeries? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.AreaChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.AreaChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredAreaSeries = GetFilteredAreaSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.AreaChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
