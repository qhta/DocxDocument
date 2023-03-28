namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceSerExtensionList Class converter from/to OpenXml.
///</summary>
public static class SurfaceSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.SurfaceSerExtension>? GetSurfaceSerExtensions(DXDrawCharts.SurfaceSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SurfaceSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SurfaceSerExtension>())
    {
      var newItem = DMXDrawsCharts.SurfaceSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSurfaceSerExtensions(DXDrawCharts.SurfaceSerExtensionList openXmlElement, Collection<DMDrawsCharts.SurfaceSerExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.SurfaceSerExtension>();
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
        if (!DMXDrawsCharts.SurfaceSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
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
  
  public static DocumentModel.Drawings.Charts.SurfaceSerExtensionList? CreateModelElement(DXDrawCharts.SurfaceSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceSerExtensionList();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceSerExtensionList value)
    where OpenXmlElementType: DXDrawCharts.SurfaceSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.SurfaceSerExtensionList openXmlElement, DMDrawsCharts.SurfaceSerExtensionList value)
  {
    SetSurfaceSerExtensions(openXmlElement, value?.SurfaceSerExtensions);
  }
}
