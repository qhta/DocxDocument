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
  
  private static void SetUri(DXDrawCharts.Pie3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredPieSeries? GetFilteredPieSeries(DXDrawCharts.Pie3DChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredPieSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredPieSeriesConverter.CreateModelElement(itemElement);
    return null;
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
