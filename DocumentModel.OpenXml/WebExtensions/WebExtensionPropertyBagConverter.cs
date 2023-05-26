namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public static class WebExtensionPropertyBagConverter
{
  private static Collection<DMWE.WebExtensionProperty>? GetWebExtensionProperties(DXO13WE.WebExtensionPropertyBag openXmlElement)
  {
    var collection = new Collection<DMWE.WebExtensionProperty>();
    foreach (var item in openXmlElement.Elements<DXO13WE.WebExtensionProperty>())
    {
      var newItem = DMXWE.WebExtensionPropertyConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpWebExtensionProperties(DXO13WE.WebExtensionPropertyBag openXmlElement, Collection<DMWE.WebExtensionProperty>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO13WE.WebExtensionProperty>();
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
        if (!DMXWE.WebExtensionPropertyConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetWebExtensionProperties(DXO13WE.WebExtensionPropertyBag openXmlElement, Collection<DMWE.WebExtensionProperty>? value)
  {
    openXmlElement.RemoveAllChildren<DXO13WE.WebExtensionProperty>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWE.WebExtensionPropertyConverter.CreateOpenXmlElement<DXO13WE.WebExtensionProperty>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionPropertyBag? CreateModelElement(DXO13WE.WebExtensionPropertyBag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionPropertyBag();
      value.WebExtensionProperties = GetWebExtensionProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13WE.WebExtensionPropertyBag? openXmlElement, DMWE.WebExtensionPropertyBag? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWebExtensionProperties(openXmlElement, value.WebExtensionProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWE.WebExtensionPropertyBag value)
    where OpenXmlElementType: DXO13WE.WebExtensionPropertyBag, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WE.WebExtensionPropertyBag openXmlElement, DMWE.WebExtensionPropertyBag value)
  {
    SetWebExtensionProperties(openXmlElement, value?.WebExtensionProperties);
  }
}
