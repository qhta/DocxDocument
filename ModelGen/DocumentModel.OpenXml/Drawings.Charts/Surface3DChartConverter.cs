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
    return openXmlElement.GetFirstChild<DXDrawCharts.Wireframe>() != null;
  }
  
  private static bool CmpWireframe(DXDrawCharts.Surface3DChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Wireframe>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Wireframe", val, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.Surface3DChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
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
  
  private static Collection<DMDrawsCharts.SurfaceChartSeries>? GetSurfaceChartSeries(DXDrawCharts.Surface3DChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SurfaceChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SurfaceChartSeries>())
    {
      var newItem = DMXDrawsCharts.SurfaceChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSurfaceChartSeries(DXDrawCharts.Surface3DChart openXmlElement, Collection<DMDrawsCharts.SurfaceChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.SurfaceChartSeries>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsCharts.SurfaceChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSurfaceChartSeries(DXDrawCharts.Surface3DChart openXmlElement, Collection<DMDrawsCharts.SurfaceChartSeries>? value)
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.BandFormats>();
    if (element != null)
      return DMXDrawsCharts.BandFormatsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBandFormats(DXDrawCharts.Surface3DChart openXmlElement, DMDrawsCharts.BandFormats? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BandFormatsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.BandFormats>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static Collection<UInt32>? GetAxisIds(DXDrawCharts.Surface3DChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxisIds(DXDrawCharts.Surface3DChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.AxisId>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!UInt32ValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Surface3DChartExtensionList>();
    if (element != null)
      return DMXDrawsCharts.Surface3DChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurface3DChartExtensionList(DXDrawCharts.Surface3DChart openXmlElement, DMDrawsCharts.Surface3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Surface3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Surface3DChartExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.Charts.Surface3DChart? CreateModelElement(DXDrawCharts.Surface3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Surface3DChart();
      value.Wireframe = GetWireframe(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.SurfaceChartSeries = GetSurfaceChartSeries(openXmlElement);
      value.BandFormats = GetBandFormats(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Surface3DChartExtensionList = GetSurface3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Surface3DChart? openXmlElement, DMDrawsCharts.Surface3DChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWireframe(openXmlElement, value.Wireframe, diffs, objName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpSurfaceChartSeries(openXmlElement, value.SurfaceChartSeries, diffs, objName))
        ok = false;
      if (!CmpBandFormats(openXmlElement, value.BandFormats, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpSurface3DChartExtensionList(openXmlElement, value.Surface3DChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Surface3DChart value)
    where OpenXmlElementType: DXDrawCharts.Surface3DChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.Surface3DChart openXmlElement, DMDrawsCharts.Surface3DChart value)
  {
    SetWireframe(openXmlElement, value?.Wireframe);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
    SetBandFormats(openXmlElement, value?.BandFormats);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetSurface3DChartExtensionList(openXmlElement, value?.Surface3DChartExtensionList);
  }
}
