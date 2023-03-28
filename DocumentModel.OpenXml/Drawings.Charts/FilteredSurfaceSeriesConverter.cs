namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredSurfaceSeries Class converter from/to OpenXml.
///</summary>
public static class FilteredSurfaceSeriesConverter
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  private static DMDrawsCharts.SurfaceChartSeries3? GetSurfaceChartSeries(DXO2013DrawChart.FilteredSurfaceSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.SurfaceChartSeries>();
    if (element != null)
      return DMXDrawsCharts.SurfaceChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurfaceChartSeries(DXO2013DrawChart.FilteredSurfaceSeries openXmlElement, DMDrawsCharts.SurfaceChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SurfaceChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.SurfaceChartSeries>(), value, diffs, objName);
  }
  
  private static void SetSurfaceChartSeries(DXO2013DrawChart.FilteredSurfaceSeries openXmlElement, DMDrawsCharts.SurfaceChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.SurfaceChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SurfaceChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.SurfaceChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredSurfaceSeries? CreateModelElement(DXO2013DrawChart.FilteredSurfaceSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredSurfaceSeries();
      value.SurfaceChartSeries = GetSurfaceChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredSurfaceSeries? openXmlElement, DMDrawsCharts.FilteredSurfaceSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurfaceChartSeries(openXmlElement, value.SurfaceChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredSurfaceSeries value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredSurfaceSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.FilteredSurfaceSeries openXmlElement, DMDrawsCharts.FilteredSurfaceSeries value)
  {
    SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
  }
}
