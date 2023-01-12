namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public static class BarChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.FilteredBarSeries? GetFilteredBarSeries(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredBarSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFilteredBarSeries(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension? openXmlElement, DocumentModel.Drawings.Charts.FilteredBarSeries? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.BarChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BarChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
