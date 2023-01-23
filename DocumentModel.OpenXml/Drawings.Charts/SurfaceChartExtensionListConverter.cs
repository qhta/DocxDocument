namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public static class SurfaceChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.SurfaceChartExtension> GetSurfaceChartExtensions(DXDrawCharts.SurfaceChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SurfaceChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SurfaceChartExtension>())
    {
      var newItem = DMXDrawsCharts.SurfaceChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSurfaceChartExtensions(DXDrawCharts.SurfaceChartExtensionList openXmlElement, Collection<DMDrawsCharts.SurfaceChartExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.SurfaceChartExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsCharts.SurfaceChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetSurfaceChartExtensions(DXDrawCharts.SurfaceChartExtensionList openXmlElement, Collection<DMDrawsCharts.SurfaceChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SurfaceChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.SurfaceChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.SurfaceChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.SurfaceChartExtensionList? CreateModelElement(DXDrawCharts.SurfaceChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SurfaceChartExtensionList();
      value.SurfaceChartExtensions = GetSurfaceChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SurfaceChartExtensionList? openXmlElement, DMDrawsCharts.SurfaceChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurfaceChartExtensions(openXmlElement, value.SurfaceChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.SurfaceChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurfaceChartExtensions(openXmlElement, value?.SurfaceChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
