namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionBindingList Class converter from/to OpenXml.
///</summary>
public static class WebExtensionBindingListConverter
{
  private static Collection<DMWebExt.WebExtensionBinding>? GetWebExtensionBindings(DXO2013WebExt.WebExtensionBindingList openXmlElement)
  {
    var collection = new Collection<DMWebExt.WebExtensionBinding>();
    foreach (var item in openXmlElement.Elements<DXO2013WebExt.WebExtensionBinding>())
    {
      var newItem = DMXWebExt.WebExtensionBindingConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpWebExtensionBindings(DXO2013WebExt.WebExtensionBindingList openXmlElement, Collection<DMWebExt.WebExtensionBinding>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2013WebExt.WebExtensionBinding>();
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
        if (!DMXWebExt.WebExtensionBindingConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetWebExtensionBindings(DXO2013WebExt.WebExtensionBindingList openXmlElement, Collection<DMWebExt.WebExtensionBinding>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013WebExt.WebExtensionBinding>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWebExt.WebExtensionBindingConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionBinding>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionBindingList? CreateModelElement(DXO2013WebExt.WebExtensionBindingList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionBindingList();
      value.WebExtensionBindings = GetWebExtensionBindings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtensionBindingList? openXmlElement, DMWebExt.WebExtensionBindingList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionBindingList value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionBindingList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013WebExt.WebExtensionBindingList openXmlElement, DMWebExt.WebExtensionBindingList value)
  {
    SetWebExtensionBindings(openXmlElement, value?.WebExtensionBindings);
  }
}
