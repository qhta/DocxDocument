namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Surface Charts.
/// </summary>
public static class SurfaceChartConverter
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  private static Boolean? GetWireframe(DXDrawCharts.SurfaceChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Wireframe>();
    return itemElement != null;
  }
  
  private static void SetWireframe(DXDrawCharts.SurfaceChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Wireframe>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Wireframe();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.SurfaceChartSeries> GetSurfaceChartSerieses(DXDrawCharts.SurfaceChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SurfaceChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SurfaceChartSeries>())
    {
      var newItem = DMXDrawsCharts.SurfaceChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetSurfaceChartSerieses(DXDrawCharts.SurfaceChart openXmlElement, Collection<DMDrawsCharts.SurfaceChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SurfaceChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.SurfaceChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.SurfaceChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.BandFormats? GetBandFormats(DXDrawCharts.SurfaceChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BandFormats>();
    if (itemElement != null)
      return DMXDrawsCharts.BandFormatsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBandFormats(DXDrawCharts.SurfaceChart openXmlElement, DMDrawsCharts.BandFormats? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BandFormats>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BandFormatsConverter.CreateOpenXmlElement<DXDrawCharts.BandFormats>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.SurfaceChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetAxisIds(DXDrawCharts.SurfaceChart openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXDrawCharts.AxisId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.SurfaceChartExtensionList? GetSurfaceChartExtensionList(DXDrawCharts.SurfaceChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SurfaceChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.SurfaceChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSurfaceChartExtensionList(DXDrawCharts.SurfaceChart openXmlElement, DMDrawsCharts.SurfaceChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SurfaceChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SurfaceChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.SurfaceChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.SurfaceChart? CreateModelElement(DXDrawCharts.SurfaceChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SurfaceChart();
      value.Wireframe = GetWireframe(openXmlElement);
      value.SurfaceChartSerieses = GetSurfaceChartSerieses(openXmlElement);
      value.BandFormats = GetBandFormats(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.SurfaceChartExtensionList = GetSurfaceChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceChart? value)
    where OpenXmlElementType: DXDrawCharts.SurfaceChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWireframe(openXmlElement, value?.Wireframe);
      SetSurfaceChartSerieses(openXmlElement, value?.SurfaceChartSerieses);
      SetBandFormats(openXmlElement, value?.BandFormats);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetSurfaceChartExtensionList(openXmlElement, value?.SurfaceChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
