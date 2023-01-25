namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceSerExtensionList Class.
/// </summary>
public static class SurfaceSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.SurfaceSerExtension> GetSurfaceSerExtensions(DXDrawCharts.SurfaceSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SurfaceSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SurfaceSerExtension>())
    {
      var newItem = DMXDrawsCharts.SurfaceSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSurfaceSerExtensions(DXDrawCharts.SurfaceSerExtensionList openXmlElement, Collection<DMDrawsCharts.SurfaceSerExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.SurfaceSerExtension>();
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
        if (!DMXDrawsCharts.SurfaceSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSurfaceSerExtensions(DXDrawCharts.SurfaceSerExtensionList openXmlElement, Collection<DMDrawsCharts.SurfaceSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SurfaceSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.SurfaceSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.SurfaceSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.SurfaceSerExtensionList? CreateModelElement(DXDrawCharts.SurfaceSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SurfaceSerExtensionList();
      value.SurfaceSerExtensions = GetSurfaceSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SurfaceSerExtensionList? openXmlElement, DMDrawsCharts.SurfaceSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurfaceSerExtensions(openXmlElement, value.SurfaceSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.SurfaceSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurfaceSerExtensions(openXmlElement, value?.SurfaceSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
