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
    return openXmlElement.GetFirstChild<DXDrawCharts.Wireframe>() != null;
  }
  
  private static bool CmpWireframe(DXDrawCharts.SurfaceChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Wireframe>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Wireframe", val, value);
    return false;
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
  
  private static Collection<DMDrawsCharts.SurfaceChartSeries> GetSurfaceChartSeries(DXDrawCharts.SurfaceChart openXmlElement)
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
  
  private static bool CmpSurfaceChartSeries(DXDrawCharts.SurfaceChart openXmlElement, Collection<DMDrawsCharts.SurfaceChartSeries>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.SurfaceChartSeries>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSurfaceChartSeries(DXDrawCharts.SurfaceChart openXmlElement, Collection<DMDrawsCharts.SurfaceChartSeries>? value)
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
    return DMXDrawsCharts.BandFormatsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.BandFormats>());
  }
  
  private static bool CmpBandFormats(DXDrawCharts.SurfaceChart openXmlElement, DMDrawsCharts.BandFormats? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BandFormatsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.BandFormats>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpAxisIds(DXDrawCharts.SurfaceChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.AxisId>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
    return DMXDrawsCharts.SurfaceChartExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SurfaceChartExtensionList>());
  }
  
  private static bool CmpSurfaceChartExtensionList(DXDrawCharts.SurfaceChart openXmlElement, DMDrawsCharts.SurfaceChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SurfaceChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SurfaceChartExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
      value.SurfaceChartSeries = GetSurfaceChartSeries(openXmlElement);
      value.BandFormats = GetBandFormats(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.SurfaceChartExtensionList = GetSurfaceChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SurfaceChart? openXmlElement, DMDrawsCharts.SurfaceChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWireframe(openXmlElement, value.Wireframe, diffs, objName))
        ok = false;
      if (!CmpSurfaceChartSeries(openXmlElement, value.SurfaceChartSeries, diffs, objName))
        ok = false;
      if (!CmpBandFormats(openXmlElement, value.BandFormats, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpSurfaceChartExtensionList(openXmlElement, value.SurfaceChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceChart? value)
    where OpenXmlElementType: DXDrawCharts.SurfaceChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWireframe(openXmlElement, value?.Wireframe);
      SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
      SetBandFormats(openXmlElement, value?.BandFormats);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetSurfaceChartExtensionList(openXmlElement, value?.SurfaceChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
