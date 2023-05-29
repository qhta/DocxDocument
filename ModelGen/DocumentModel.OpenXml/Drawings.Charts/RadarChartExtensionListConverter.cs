namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RadarChartExtensionList Class.
/// </summary>
public static class RadarChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.RadarChartExtension>? GetRadarChartExtensions(DXDrawCharts.RadarChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.RadarChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.RadarChartExtension>())
    {
      var newItem = DMXDrawsCharts.RadarChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpRadarChartExtensions(DXDrawCharts.RadarChartExtensionList openXmlElement, Collection<DMDrawsCharts.RadarChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.RadarChartExtension>();
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
        if (!DMXDrawsCharts.RadarChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetRadarChartExtensions(DXDrawCharts.RadarChartExtensionList openXmlElement, Collection<DMDrawsCharts.RadarChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.RadarChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.RadarChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.RadarChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.RadarChartExtensionList? CreateModelElement(DXDrawCharts.RadarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RadarChartExtensionList();
      value.RadarChartExtensions = GetRadarChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.RadarChartExtensionList? openXmlElement, DMDrawsCharts.RadarChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadarChartExtensions(openXmlElement, value.RadarChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.RadarChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.RadarChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.RadarChartExtensionList openXmlElement, DMDrawsCharts.RadarChartExtensionList value)
  {
    SetRadarChartExtensions(openXmlElement, value?.RadarChartExtensions);
  }
}
