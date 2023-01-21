namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Band Format.
/// </summary>
public static class BandFormatConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.BandFormat openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DXDrawCharts.BandFormat openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Index{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.BandFormat openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.BandFormat openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  
  public static DMDrawsCharts.BandFormat? CreateModelElement(DXDrawCharts.BandFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BandFormat();
      value.Index = GetIndex(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BandFormat? value)
    where OpenXmlElementType: DXDrawCharts.BandFormat, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
