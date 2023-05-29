namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtensionList Class.
/// </summary>
public static class Surface3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Surface3DChartExtension>? GetSurface3DChartExtensions(DXDrawCharts.Surface3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Surface3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Surface3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Surface3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSurface3DChartExtensions(DXDrawCharts.Surface3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Surface3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.Surface3DChartExtension>();
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
        if (!DMXDrawsCharts.Surface3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSurface3DChartExtensions(DXDrawCharts.Surface3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Surface3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Surface3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Surface3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Surface3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Surface3DChartExtensionList? CreateModelElement(DXDrawCharts.Surface3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Surface3DChartExtensionList();
      value.Surface3DChartExtensions = GetSurface3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Surface3DChartExtensionList? openXmlElement, DMDrawsCharts.Surface3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurface3DChartExtensions(openXmlElement, value.Surface3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Surface3DChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.Surface3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.Surface3DChartExtensionList openXmlElement, DMDrawsCharts.Surface3DChartExtensionList value)
  {
    SetSurface3DChartExtensions(openXmlElement, value?.Surface3DChartExtensions);
  }
}
