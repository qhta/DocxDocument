namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionBindingList Class.
/// </summary>
public static class WebExtensionBindingListConverter
{
  private static Collection<DMWE.WebExtensionBinding>? GetWebExtensionBindings(DXO13WE.WebExtensionBindingList openXmlElement)
  {
    var collection = new Collection<DMWE.WebExtensionBinding>();
    foreach (var item in openXmlElement.Elements<DXO13WE.WebExtensionBinding>())
    {
      var newItem = DMXWE.WebExtensionBindingConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpWebExtensionBindings(DXO13WE.WebExtensionBindingList openXmlElement, Collection<DMWE.WebExtensionBinding>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO13WE.WebExtensionBinding>();
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
        if (!DMXWE.WebExtensionBindingConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetWebExtensionBindings(DXO13WE.WebExtensionBindingList openXmlElement, Collection<DMWE.WebExtensionBinding>? value)
  {
    openXmlElement.RemoveAllChildren<DXO13WE.WebExtensionBinding>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWE.WebExtensionBindingConverter.CreateOpenXmlElement<DXO13WE.WebExtensionBinding>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionBindingList? CreateModelElement(DXO13WE.WebExtensionBindingList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionBindingList();
      value.WebExtensionBindings = GetWebExtensionBindings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13WE.WebExtensionBindingList? openXmlElement, DMWE.WebExtensionBindingList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWebExtensionBindings(openXmlElement, value.WebExtensionBindings, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWE.WebExtensionBindingList value)
    where OpenXmlElementType: DXO13WE.WebExtensionBindingList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WE.WebExtensionBindingList openXmlElement, DMWE.WebExtensionBindingList value)
  {
    SetWebExtensionBindings(openXmlElement, value?.WebExtensionBindings);
  }
}
