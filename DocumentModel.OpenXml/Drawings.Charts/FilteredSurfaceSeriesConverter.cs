namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
public static class FilteredSurfaceSeriesConverter
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  public static DocumentModel.Drawings.Charts.SurfaceChartSeries3? GetSurfaceChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SurfaceChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSurfaceChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries? openXmlElement, DocumentModel.Drawings.Charts.SurfaceChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.SurfaceChartSeries3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredSurfaceSeries? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredSurfaceSeries();
      value.SurfaceChartSeries = GetSurfaceChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredSurfaceSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
