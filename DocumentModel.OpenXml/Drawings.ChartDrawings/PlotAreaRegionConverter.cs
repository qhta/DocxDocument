namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public static class PlotAreaRegionConverter
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  private static DMDrawsChartDraws.PlotSurface? GetPlotSurface(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement)
  {
    return DMXDrawsChartDraws.PlotSurfaceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PlotSurface>());
  }
  
  private static bool CmpPlotSurface(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement, DMDrawsChartDraws.PlotSurface? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.PlotSurfaceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PlotSurface>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPlotSurface(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement, DMDrawsChartDraws.PlotSurface? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PlotSurface>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.PlotSurfaceConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.PlotSurface>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsChartDraws.Series> GetSeries(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.Series>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.Series>())
    {
      var newItem = DMXDrawsChartDraws.SeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSeries(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement, Collection<DMDrawsChartDraws.Series>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.Series>();
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
        if (!DMXDrawsChartDraws.SeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSeries(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement, Collection<DMDrawsChartDraws.Series>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.Series>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.SeriesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Series>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.PlotAreaRegion openXmlElement, DMDrawsChartDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExtensionListConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.PlotAreaRegion? CreateModelElement(DXO2016DrawChartDraw.PlotAreaRegion? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.PlotAreaRegion();
      value.PlotSurface = GetPlotSurface(openXmlElement);
      value.Series = GetSeries(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.PlotAreaRegion? openXmlElement, DMDrawsChartDraws.PlotAreaRegion? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.PlotAreaRegion? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.PlotAreaRegion, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPlotSurface(openXmlElement, value?.PlotSurface);
      SetSeries(openXmlElement, value?.Series);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
