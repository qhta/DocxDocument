namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public static class MismatchedKeyMapCustomizationConverter
{
  private static Collection<DMW.KeyMapEntry>? GetKeyMapEntries(DXOW.MismatchedKeyMapCustomization openXmlElement)
  {
    var collection = new Collection<DMW.KeyMapEntry>();
    foreach (var item in openXmlElement.Elements<DXOW.KeyMapEntry>())
    {
      var newItem = DMXW.KeyMapEntryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpKeyMapEntries(DXOW.MismatchedKeyMapCustomization openXmlElement, Collection<DMW.KeyMapEntry>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOW.KeyMapEntry>();
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
        if (!DMXW.KeyMapEntryConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetKeyMapEntries(DXOW.MismatchedKeyMapCustomization openXmlElement, Collection<DMW.KeyMapEntry>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.KeyMapEntry>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.KeyMapEntryConverter.CreateOpenXmlElement<DXOW.KeyMapEntry>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MismatchedKeyMapCustomization? CreateModelElement(DXOW.MismatchedKeyMapCustomization? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MismatchedKeyMapCustomization();
      value.KeyMapEntries = GetKeyMapEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.MismatchedKeyMapCustomization? openXmlElement, DMW.MismatchedKeyMapCustomization? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpKeyMapEntries(openXmlElement, value.KeyMapEntries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MismatchedKeyMapCustomization value)
    where OpenXmlElementType: DXOW.MismatchedKeyMapCustomization, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.MismatchedKeyMapCustomization openXmlElement, DMW.MismatchedKeyMapCustomization value)
  {
    SetKeyMapEntries(openXmlElement, value?.KeyMapEntries);
  }
}
