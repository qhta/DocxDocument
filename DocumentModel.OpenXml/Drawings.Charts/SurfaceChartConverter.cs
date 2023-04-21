namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Surface Charts.
/// </summary>
public static class SurfaceChartConverter
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  private static Boolean? GetWireframe(DXDC.SurfaceChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Wireframe>() != null;
  }
  
  private static bool CmpWireframe(DXDC.SurfaceChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Wireframe>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Wireframe", val, value);
    return false;
  }
  
  private static void SetWireframe(DXDC.SurfaceChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.SurfaceChartSeries>? GetSurfaceChartSeries(DXDC.SurfaceChart openXmlElement)
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
  
  private static bool CmpSurfaceChartSeries(DXDC.SurfaceChart openXmlElement, Collection<DMDC.SurfaceChartSeries>? value, DiffList? diffs, string? objName)
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
  
  private static void SetSurfaceChartSeries(DXDC.SurfaceChart openXmlElement, Collection<DMDC.SurfaceChartSeries>? value)
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
  
  private static DMDC.BandFormats? GetBandFormats(DXDC.SurfaceChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BandFormats>();
    if (element != null)
      return DMXDC.BandFormatsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBandFormats(DXDC.SurfaceChart openXmlElement, DMDC.BandFormats? value, DiffList? diffs, string? objName)
  {
    return DMXDC.BandFormatsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BandFormats>(), value, diffs, objName);
  }
  
  private static void SetBandFormats(DXDC.SurfaceChart openXmlElement, DMDC.BandFormats? value)
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
  
  private static Collection<UInt32>? GetAxisIds(DXDC.SurfaceChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDC.SurfaceChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
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
  
  private static void SetAxisIds(DXDC.SurfaceChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDC.SurfaceChartExtensionList? GetSurfaceChartExtensionList(DXDC.SurfaceChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SurfaceChartExtensionList>();
    if (element != null)
      return DMXDC.SurfaceChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurfaceChartExtensionList(DXDC.SurfaceChart openXmlElement, DMDC.SurfaceChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SurfaceChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SurfaceChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetSurfaceChartExtensionList(DXDC.SurfaceChart openXmlElement, DMDC.SurfaceChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SurfaceChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SurfaceChartExtensionListConverter.CreateOpenXmlElement<DXDC.SurfaceChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChart? CreateModelElement(DXDC.SurfaceChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChart();
      value.Wireframe = GetWireframe(openXmlElement);
      value.SurfaceChartSeries = GetSurfaceChartSeries(openXmlElement);
      value.BandFormats = GetBandFormats(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.SurfaceChartExtensionList = GetSurfaceChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.SurfaceChart? openXmlElement, DMDC.SurfaceChart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SurfaceChart value)
    where OpenXmlElementType: DXDC.SurfaceChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.SurfaceChart openXmlElement, DMDC.SurfaceChart value)
  {
    SetWireframe(openXmlElement, value?.Wireframe);
    SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
    SetBandFormats(openXmlElement, value?.BandFormats);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetSurfaceChartExtensionList(openXmlElement, value?.SurfaceChartExtensionList);
  }
}
