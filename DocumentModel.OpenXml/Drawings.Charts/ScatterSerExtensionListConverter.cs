namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtensionList Class.
/// </summary>
public static class ScatterSerExtensionListConverter
{
  private static Collection<DMDC.ScatterSerExtension>? GetScatterSerExtensions(DXDC.ScatterSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.ScatterSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.ScatterSerExtension>())
    {
      var newItem = DMXDC.ScatterSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpScatterSerExtensions(DXDC.ScatterSerExtensionList openXmlElement, Collection<DMDC.ScatterSerExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.ScatterSerExtension>();
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
        if (!DMXDC.ScatterSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetScatterSerExtensions(DXDC.ScatterSerExtensionList openXmlElement, Collection<DMDC.ScatterSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.ScatterSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.ScatterSerExtensionConverter.CreateOpenXmlElement<DXDC.ScatterSerExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.Charts.ScatterSerExtensionList? CreateModelElement(DXDC.ScatterSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.ScatterSerExtensionList();
      value.ScatterSerExtensions = GetScatterSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ScatterSerExtensionList? openXmlElement, DMDC.ScatterSerExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterSerExtensions(openXmlElement, value.ScatterSerExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ScatterSerExtensionList value)
    where OpenXmlElementType: DXDC.ScatterSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ScatterSerExtensionList openXmlElement, DMDC.ScatterSerExtensionList value)
  {
    SetScatterSerExtensions(openXmlElement, value?.ScatterSerExtensions);
  }
}
