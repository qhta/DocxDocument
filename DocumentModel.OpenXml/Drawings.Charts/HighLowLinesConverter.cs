namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the HighLowLines Class.
/// </summary>
public static class HighLowLinesConverter
{
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.HighLowLines openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.HighLowLines openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.HighLowLines? CreateModelElement(DXDrawCharts.HighLowLines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.HighLowLines();
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.HighLowLines? value)
    where OpenXmlElementType: DXDrawCharts.HighLowLines, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
