namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public static class FilteredAreaSeriesConverter
{
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  public static DocumentModel.Drawings.Charts.AreaChartSeries3? GetAreaChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.AreaChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAreaChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries? openXmlElement, DocumentModel.Drawings.Charts.AreaChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.AreaChartSeries3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredAreaSeries? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredAreaSeries();
      value.AreaChartSeries = GetAreaChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredAreaSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaChartSeries(openXmlElement, value?.AreaChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
