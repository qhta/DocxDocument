namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public static class Pie3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.FilteredPieSeries? GetFilteredPieSeries(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredPieSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredPieSeries(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredPieSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredPieSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Pie3DChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Pie3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredPieSeries = GetFilteredPieSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Pie3DChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredPieSeries(openXmlElement, value?.FilteredPieSeries);
      return openXmlElement;
    }
    return default;
  }
}
