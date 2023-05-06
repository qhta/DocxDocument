namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public static class SurfaceChartExtensionListConverter
{
  private static Collection<DMDC.SurfaceChartExtension>? GetSurfaceChartExtensions(DXDC.SurfaceChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.SurfaceChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.SurfaceChartExtension>())
    {
      var newItem = DMXDC.SurfaceChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSurfaceChartExtensions(DXDC.SurfaceChartExtensionList openXmlElement, Collection<DMDC.SurfaceChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.SurfaceChartExtension>();
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
        if (!DMXDC.SurfaceChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSurfaceChartExtensions(DXDC.SurfaceChartExtensionList openXmlElement, Collection<DMDC.SurfaceChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.SurfaceChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.SurfaceChartExtensionConverter.CreateOpenXmlElement<DXDC.SurfaceChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChartExtensionList? CreateModelElement(DXDC.SurfaceChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChartExtensionList();
      value.SurfaceChartExtensions = GetSurfaceChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.SurfaceChartExtensionList? openXmlElement, DMDC.SurfaceChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurfaceChartExtensions(openXmlElement, value.SurfaceChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SurfaceChartExtensionList value)
    where OpenXmlElementType: DXDC.SurfaceChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.SurfaceChartExtensionList openXmlElement, DMDC.SurfaceChartExtensionList value)
  {
    SetSurfaceChartExtensions(openXmlElement, value?.SurfaceChartExtensions);
  }
}
