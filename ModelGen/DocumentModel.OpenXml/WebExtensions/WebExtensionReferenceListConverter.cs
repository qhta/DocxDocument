namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public static class WebExtensionReferenceListConverter
{
  private static Collection<DMWebExt.WebExtensionStoreReference>? GetWebExtensionStoreReferences(DXO2013WebExt.WebExtensionReferenceList openXmlElement)
  {
    var collection = new Collection<DMWebExt.WebExtensionStoreReference>();
    foreach (var item in openXmlElement.Elements<DXO2013WebExt.WebExtensionStoreReference>())
    {
      var newItem = DMXWebExt.WebExtensionStoreReferenceConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpWebExtensionStoreReferences(DXO2013WebExt.WebExtensionReferenceList openXmlElement, Collection<DMWebExt.WebExtensionStoreReference>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2013WebExt.WebExtensionStoreReference>();
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
        if (!DMXWebExt.WebExtensionStoreReferenceConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetWebExtensionStoreReferences(DXO2013WebExt.WebExtensionReferenceList openXmlElement, Collection<DMWebExt.WebExtensionStoreReference>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013WebExt.WebExtensionStoreReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWebExt.WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionStoreReference>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionReferenceList? CreateModelElement(DXO2013WebExt.WebExtensionReferenceList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionReferenceList();
      value.WebExtensionStoreReferences = GetWebExtensionStoreReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtensionReferenceList? openXmlElement, DMWebExt.WebExtensionReferenceList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWebExtensionStoreReferences(openXmlElement, value.WebExtensionStoreReferences, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionReferenceList value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionReferenceList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013WebExt.WebExtensionReferenceList openXmlElement, DMWebExt.WebExtensionReferenceList value)
  {
    SetWebExtensionStoreReferences(openXmlElement, value?.WebExtensionStoreReferences);
  }
}
