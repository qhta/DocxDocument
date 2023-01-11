namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredRadarSeries Class.
/// </summary>
public static class FilteredRadarSeriesConverter
{
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  public static DocumentModel.Drawings.Charts.RadarChartSeries3? GetRadarChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.RadarChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRadarChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries? openXmlElement, DocumentModel.Drawings.Charts.RadarChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.RadarChartSeries3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredRadarSeries? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredRadarSeries();
      value.RadarChartSeries = GetRadarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredRadarSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
