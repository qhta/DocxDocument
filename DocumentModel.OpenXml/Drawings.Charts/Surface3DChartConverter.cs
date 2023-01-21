namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public static class Surface3DChartConverter
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  private static Boolean? GetWireframe(DXDrawCharts.Surface3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Wireframe>();
    return itemElement != null;
  }
  
  private static void SetWireframe(DXDrawCharts.Surface3DChart openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.Surface3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.Surface3DChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.VaryColors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.SurfaceChartSeries> GetSurfaceChartSerieses(DXDrawCharts.Surface3DChart openXmlElement)
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
  
  private static void SetSurfaceChartSerieses(DXDrawCharts.Surface3DChart openXmlElement, Collection<DMDrawsCharts.SurfaceChartSeries>? value)
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
  
  private static DMDrawsCharts.BandFormats? GetBandFormats(DXDrawCharts.Surface3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BandFormats>();
    if (itemElement != null)
      return DMXDrawsCharts.BandFormatsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBandFormats(DXDrawCharts.Surface3DChart openXmlElement, DMDrawsCharts.BandFormats? value)
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
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.Surface3DChart openXmlElement)
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
  
  private static void SetAxisIds(DXDrawCharts.Surface3DChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.Surface3DChartExtensionList? GetSurface3DChartExtensionList(DXDrawCharts.Surface3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Surface3DChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.Surface3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSurface3DChartExtensionList(DXDrawCharts.Surface3DChart openXmlElement, DMDrawsCharts.Surface3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Surface3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Surface3DChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.Surface3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Surface3DChart? CreateModelElement(DXDrawCharts.Surface3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Surface3DChart();
      value.Wireframe = GetWireframe(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.SurfaceChartSerieses = GetSurfaceChartSerieses(openXmlElement);
      value.BandFormats = GetBandFormats(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Surface3DChartExtensionList = GetSurface3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Surface3DChart? value)
    where OpenXmlElementType: DXDrawCharts.Surface3DChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWireframe(openXmlElement, value?.Wireframe);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetSurfaceChartSerieses(openXmlElement, value?.SurfaceChartSerieses);
      SetBandFormats(openXmlElement, value?.BandFormats);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetSurface3DChartExtensionList(openXmlElement, value?.Surface3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
