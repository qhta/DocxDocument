namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceSerExtensionList Class.
/// </summary>
public static class SurfaceSerExtensionListConverter
{
  private static Collection<DMDC.SurfaceSerExtension>? GetSurfaceSerExtensions(DXDC.SurfaceSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.SurfaceSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.SurfaceSerExtension>())
    {
      var newItem = DMXDC.SurfaceSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSurfaceSerExtensions(DXDC.SurfaceSerExtensionList openXmlElement, Collection<DMDC.SurfaceSerExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.SurfaceSerExtension>();
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
        if (!DMXDC.SurfaceSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSurfaceSerExtensions(DXDC.SurfaceSerExtensionList openXmlElement, Collection<DMDC.SurfaceSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.SurfaceSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.SurfaceSerExtensionConverter.CreateOpenXmlElement<DXDC.SurfaceSerExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.Charts.SurfaceSerExtensionList? CreateModelElement(DXDC.SurfaceSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.SurfaceSerExtensionList();
      value.SurfaceSerExtensions = GetSurfaceSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.SurfaceSerExtensionList? openXmlElement, DMDC.SurfaceSerExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurfaceSerExtensions(openXmlElement, value.SurfaceSerExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SurfaceSerExtensionList value)
    where OpenXmlElementType: DXDC.SurfaceSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.SurfaceSerExtensionList openXmlElement, DMDC.SurfaceSerExtensionList value)
  {
    SetSurfaceSerExtensions(openXmlElement, value?.SurfaceSerExtensions);
  }
}
