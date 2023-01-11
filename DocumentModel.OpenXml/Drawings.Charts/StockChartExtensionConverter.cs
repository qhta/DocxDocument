namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public static class StockChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredLineSeriesExtensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFilteredLineSeriesExtension(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension? openXmlElement, DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredLineSeriesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StockChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StockChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredLineSeriesExtension = GetFilteredLineSeriesExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StockChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
