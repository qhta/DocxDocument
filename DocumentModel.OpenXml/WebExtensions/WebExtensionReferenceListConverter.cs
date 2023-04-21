namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public static class WebExtensionReferenceListConverter
{
  private static Collection<DMWE.WebExtensionStoreReference>? GetWebExtensionStoreReferences(DXO13WE.WebExtensionReferenceList openXmlElement)
  {
    var collection = new Collection<DMWE.WebExtensionStoreReference>();
    foreach (var item in openXmlElement.Elements<DXO13WE.WebExtensionStoreReference>())
    {
      var newItem = DMXWE.WebExtensionStoreReferenceConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpWebExtensionStoreReferences(DXO13WE.WebExtensionReferenceList openXmlElement, Collection<DMWE.WebExtensionStoreReference>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO13WE.WebExtensionStoreReference>();
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
        if (!DMXWE.WebExtensionStoreReferenceConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetWebExtensionStoreReferences(DXO13WE.WebExtensionReferenceList openXmlElement, Collection<DMWE.WebExtensionStoreReference>? value)
  {
    openXmlElement.RemoveAllChildren<DXO13WE.WebExtensionStoreReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXWE.WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DXO13WE.WebExtensionStoreReference>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtensionReferenceList? CreateModelElement(DXO13WE.WebExtensionReferenceList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionReferenceList();
      value.WebExtensionStoreReferences = GetWebExtensionStoreReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13WE.WebExtensionReferenceList? openXmlElement, DMWE.WebExtensionReferenceList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWE.WebExtensionReferenceList value)
    where OpenXmlElementType: DXO13WE.WebExtensionReferenceList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WE.WebExtensionReferenceList openXmlElement, DMWE.WebExtensionReferenceList value)
  {
    SetWebExtensionStoreReferences(openXmlElement, value?.WebExtensionStoreReferences);
  }
}
