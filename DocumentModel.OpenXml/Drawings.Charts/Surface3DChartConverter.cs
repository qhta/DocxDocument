namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public static class Surface3DChartConverter
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  private static Boolean? GetWireframe(DXDC.Surface3DChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Wireframe>() != null;
  }
  
  private static bool CmpWireframe(DXDC.Surface3DChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Wireframe>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Wireframe", val, value);
    return false;
  }
  
  private static void SetWireframe(DXDC.Surface3DChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Wireframe>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Wireframe();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.Surface3DChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.Surface3DChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.Surface3DChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.VaryColors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDC.SurfaceChartSeries>? GetSurfaceChartSeries(DXDC.Surface3DChart openXmlElement)
  {
    var collection = new Collection<DMDC.SurfaceChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDC.SurfaceChartSeries>())
    {
      var newItem = DMXDC.SurfaceChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSurfaceChartSeries(DXDC.Surface3DChart openXmlElement, Collection<DMDC.SurfaceChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.SurfaceChartSeries>();
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
        if (!DMXDC.SurfaceChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSurfaceChartSeries(DXDC.Surface3DChart openXmlElement, Collection<DMDC.SurfaceChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.SurfaceChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.SurfaceChartSeriesConverter.CreateOpenXmlElement<DXDC.SurfaceChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDC.BandFormats? GetBandFormats(DXDC.Surface3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BandFormats>();
    if (element != null)
      return DMXDC.BandFormatsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBandFormats(DXDC.Surface3DChart openXmlElement, DMDC.BandFormats? value, DiffList? diffs, string? objName)
  {
    return DMXDC.BandFormatsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BandFormats>(), value, diffs, objName);
  }
  
  private static void SetBandFormats(DXDC.Surface3DChart openXmlElement, DMDC.BandFormats? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BandFormats>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BandFormatsConverter.CreateOpenXmlElement<DXDC.BandFormats>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDC.Surface3DChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDC.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxisIds(DXDC.Surface3DChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.AxisId>();
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
  
  private static void SetAxisIds(DXDC.Surface3DChart openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXDC.AxisId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDC.Surface3DChartExtensionList? GetSurface3DChartExtensionList(DXDC.Surface3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Surface3DChartExtensionList>();
    if (element != null)
      return DMXDC.Surface3DChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurface3DChartExtensionList(DXDC.Surface3DChart openXmlElement, DMDC.Surface3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.Surface3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Surface3DChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetSurface3DChartExtensionList(DXDC.Surface3DChart openXmlElement, DMDC.Surface3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Surface3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Surface3DChartExtensionListConverter.CreateOpenXmlElement<DXDC.Surface3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Surface3DChart? CreateModelElement(DXDC.Surface3DChart? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.Surface3DChart? openXmlElement, DMDC.Surface3DChart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Surface3DChart value)
    where OpenXmlElementType: DXDC.Surface3DChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Surface3DChart openXmlElement, DMDC.Surface3DChart value)
  {
    SetWireframe(openXmlElement, value?.Wireframe);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
    SetBandFormats(openXmlElement, value?.BandFormats);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetSurface3DChartExtensionList(openXmlElement, value?.Surface3DChartExtensionList);
  }
}
