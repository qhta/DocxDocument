namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
public static class FilteredScatterSeriesConverter
{
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ScatterChartSeries3? GetScatterChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ScatterChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScatterChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries openXmlElement, DocumentModel.Drawings.Charts.ScatterChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ScatterChartSeries3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredScatterSeries? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredScatterSeries();
      value.ScatterChartSeries = GetScatterChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredScatterSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterChartSeries(openXmlElement, value?.ScatterChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
