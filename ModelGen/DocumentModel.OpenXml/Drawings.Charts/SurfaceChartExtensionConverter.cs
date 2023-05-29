namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public static class SurfaceChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.SurfaceChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.SurfaceChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.SurfaceChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.FilteredSurfaceSeries? GetFilteredSurfaceSeries(DXDrawCharts.SurfaceChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSurfaceSeries>();
    if (element != null)
      return DMXDrawsCharts.FilteredSurfaceSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredSurfaceSeries(DXDrawCharts.SurfaceChartExtension openXmlElement, DMDrawsCharts.FilteredSurfaceSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredSurfaceSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredSurfaceSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredSurfaceSeries(DXDrawCharts.SurfaceChartExtension openXmlElement, DMDrawsCharts.FilteredSurfaceSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredSurfaceSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredSurfaceSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredSurfaceSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChartExtension? CreateModelElement(DXDrawCharts.SurfaceChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSurfaceSeries = GetFilteredSurfaceSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SurfaceChartExtension? openXmlElement, DMDrawsCharts.SurfaceChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredSurfaceSeries(openXmlElement, value.FilteredSurfaceSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceChartExtension value)
    where OpenXmlElementType: DXDrawCharts.SurfaceChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.SurfaceChartExtension openXmlElement, DMDrawsCharts.SurfaceChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredSurfaceSeries(openXmlElement, value?.FilteredSurfaceSeries);
  }
}
