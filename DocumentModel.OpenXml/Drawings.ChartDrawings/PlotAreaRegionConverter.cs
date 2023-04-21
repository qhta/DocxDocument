namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public static class PlotAreaRegionConverter
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  private static DMDCDs.PlotSurface? GetPlotSurface(DXO16DCD.PlotAreaRegion openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.PlotSurface>();
    if (element != null)
      return DMXDCDs.PlotSurfaceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlotSurface(DXO16DCD.PlotAreaRegion openXmlElement, DMDCDs.PlotSurface? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.PlotSurfaceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.PlotSurface>(), value, diffs, objName);
  }
  
  private static void SetPlotSurface(DXO16DCD.PlotAreaRegion openXmlElement, DMDCDs.PlotSurface? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.PlotSurface>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.PlotSurfaceConverter.CreateOpenXmlElement<DXO16DCD.PlotSurface>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDCDs.Series>? GetSeries(DXO16DCD.PlotAreaRegion openXmlElement)
  {
    var collection = new Collection<DMDCDs.Series>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.Series>())
    {
      var newItem = DMXDCDs.SeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSeries(DXO16DCD.PlotAreaRegion openXmlElement, Collection<DMDCDs.Series>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.Series>();
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
        if (!DMXDCDs.SeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSeries(DXO16DCD.PlotAreaRegion openXmlElement, Collection<DMDCDs.Series>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.Series>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.SeriesConverter.CreateOpenXmlElement<DXO16DCD.Series>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.PlotAreaRegion openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.PlotAreaRegion openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.PlotAreaRegion openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PlotAreaRegion? CreateModelElement(DXO16DCD.PlotAreaRegion? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PlotAreaRegion();
      value.PlotSurface = GetPlotSurface(openXmlElement);
      value.Series = GetSeries(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.PlotAreaRegion? openXmlElement, DMDCDs.PlotAreaRegion? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPlotSurface(openXmlElement, value.PlotSurface, diffs, objName))
        ok = false;
      if (!CmpSeries(openXmlElement, value.Series, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.PlotAreaRegion value)
    where OpenXmlElementType: DXO16DCD.PlotAreaRegion, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.PlotAreaRegion openXmlElement, DMDCDs.PlotAreaRegion value)
  {
    SetPlotSurface(openXmlElement, value?.PlotSurface);
    SetSeries(openXmlElement, value?.Series);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
