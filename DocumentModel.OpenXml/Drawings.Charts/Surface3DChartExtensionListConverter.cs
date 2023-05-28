namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtensionList Class.
/// </summary>
public static class Surface3DChartExtensionListConverter
{
  private static Collection<DMDC.Surface3DChartExtension>? GetSurface3DChartExtensions(DXDC.Surface3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.Surface3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.Surface3DChartExtension>())
    {
      var newItem = DMXDC.Surface3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSurface3DChartExtensions(DXDC.Surface3DChartExtensionList openXmlElement, Collection<DMDC.Surface3DChartExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.Surface3DChartExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDC.Surface3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSurface3DChartExtensions(DXDC.Surface3DChartExtensionList openXmlElement, Collection<DMDC.Surface3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.Surface3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.Surface3DChartExtensionConverter.CreateOpenXmlElement<DXDC.Surface3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.Charts.Surface3DChartExtensionList? CreateModelElement(DXDC.Surface3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Surface3DChartExtensionList();
      value.Surface3DChartExtensions = GetSurface3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Surface3DChartExtensionList? openXmlElement, DMDC.Surface3DChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurface3DChartExtensions(openXmlElement, value.Surface3DChartExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Surface3DChartExtensionList value)
    where OpenXmlElementType: DXDC.Surface3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Surface3DChartExtensionList openXmlElement, DMDC.Surface3DChartExtensionList value)
  {
    SetSurface3DChartExtensions(openXmlElement, value?.Surface3DChartExtensions);
  }
}
