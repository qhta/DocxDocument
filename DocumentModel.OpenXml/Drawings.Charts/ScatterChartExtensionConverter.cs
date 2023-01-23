namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public static class ScatterChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.ScatterChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.ScatterChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.ScatterChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredScatterSeries? GetFilteredScatterSeries(DXDrawCharts.ScatterChartExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredScatterSeriesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredScatterSeries>());
  }
  
  private static bool CmpFilteredScatterSeries(DXDrawCharts.ScatterChartExtension openXmlElement, DMDrawsCharts.FilteredScatterSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredScatterSeriesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredScatterSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredScatterSeries(DXDrawCharts.ScatterChartExtension openXmlElement, DMDrawsCharts.FilteredScatterSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredScatterSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredScatterSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredScatterSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.ScatterChartExtension? CreateModelElement(DXDrawCharts.ScatterChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ScatterChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredScatterSeries = GetFilteredScatterSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ScatterChartExtension? openXmlElement, DMDrawsCharts.ScatterChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredScatterSeries(openXmlElement, value.FilteredScatterSeries, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.ScatterChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredScatterSeries(openXmlElement, value?.FilteredScatterSeries);
      return openXmlElement;
    }
    return default;
  }
}
