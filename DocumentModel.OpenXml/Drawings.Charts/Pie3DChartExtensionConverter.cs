namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public static class Pie3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.Pie3DChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.Pie3DChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.Pie3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredPieSeries? GetFilteredPieSeries(DXDrawCharts.Pie3DChartExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredPieSeriesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredPieSeries>());
  }
  
  private static bool CmpFilteredPieSeries(DXDrawCharts.Pie3DChartExtension openXmlElement, DMDrawsCharts.FilteredPieSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredPieSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredPieSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredPieSeries(DXDrawCharts.Pie3DChartExtension openXmlElement, DMDrawsCharts.FilteredPieSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredPieSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredPieSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredPieSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Pie3DChartExtension? CreateModelElement(DXDrawCharts.Pie3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Pie3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredPieSeries = GetFilteredPieSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Pie3DChartExtension? openXmlElement, DMDrawsCharts.Pie3DChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredPieSeries(openXmlElement, value.FilteredPieSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Pie3DChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.Pie3DChartExtension, new()
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
