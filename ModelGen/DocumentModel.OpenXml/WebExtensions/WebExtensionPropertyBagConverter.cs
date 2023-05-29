namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public static class WebExtensionPropertyBagConverter
{
  private static Collection<DMWebExt.WebExtensionProperty>? GetWebExtensionProperties(DXO2013WebExt.WebExtensionPropertyBag openXmlElement)
  {
    var collection = new Collection<DMWebExt.WebExtensionProperty>();
    foreach (var item in openXmlElement.Elements<DXO2013WebExt.WebExtensionProperty>())
    {
      var newItem = DMXWebExt.WebExtensionPropertyConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpWebExtensionProperties(DXO2013WebExt.WebExtensionPropertyBag openXmlElement, Collection<DMWebExt.WebExtensionProperty>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2013WebExt.WebExtensionProperty>();
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
        if (!DMXWebExt.WebExtensionPropertyConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetWebExtensionProperties(DXO2013WebExt.WebExtensionPropertyBag openXmlElement, Collection<DMWebExt.WebExtensionProperty>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013WebExt.WebExtensionProperty>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWebExt.WebExtensionPropertyConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionProperty>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionPropertyBag? CreateModelElement(DXO2013WebExt.WebExtensionPropertyBag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionPropertyBag();
      value.WebExtensionProperties = GetWebExtensionProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtensionPropertyBag? openXmlElement, DMWebExt.WebExtensionPropertyBag? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWebExtensionProperties(openXmlElement, value.WebExtensionProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionPropertyBag value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionPropertyBag, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013WebExt.WebExtensionPropertyBag openXmlElement, DMWebExt.WebExtensionPropertyBag value)
  {
    SetWebExtensionProperties(openXmlElement, value?.WebExtensionProperties);
  }
}
