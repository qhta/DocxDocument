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
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.SurfaceChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.SurfaceChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredSurfaceSeries? GetFilteredSurfaceSeries(DXDrawCharts.SurfaceChartExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredSurfaceSeriesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSurfaceSeries>());
  }
  
  private static bool CmpFilteredSurfaceSeries(DXDrawCharts.SurfaceChartExtension openXmlElement, DMDrawsCharts.FilteredSurfaceSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredSurfaceSeriesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSurfaceSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsCharts.SurfaceChartExtension? CreateModelElement(DXDrawCharts.SurfaceChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SurfaceChartExtension();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.SurfaceChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredSurfaceSeries(openXmlElement, value?.FilteredSurfaceSeries);
      return openXmlElement;
    }
    return default;
  }
}
