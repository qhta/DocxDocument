namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
public static class FilteredBarSeriesConverter
{
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  public static DocumentModel.Drawings.Charts.BarChartSeries3? GetBarChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BarChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBarChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries? openXmlElement, DocumentModel.Drawings.Charts.BarChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.BarChartSeries3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredBarSeries? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredBarSeries();
      value.BarChartSeries = GetBarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredBarSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarChartSeries(openXmlElement, value?.BarChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
