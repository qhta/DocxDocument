namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public static class KeyMapCustomizationsConverter
{
  private static Collection<DMW.KeyMapEntry> GetKeyMapEntries(DXOW.KeyMapCustomizations openXmlElement)
  {
    var collection = new Collection<DMW.KeyMapEntry>();
    foreach (var item in openXmlElement.Elements<DXOW.KeyMapEntry>())
    {
      var newItem = DMXW.KeyMapEntryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpKeyMapEntries(DXOW.KeyMapCustomizations openXmlElement, Collection<DMW.KeyMapEntry>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetKeyMapEntries(DXOW.KeyMapCustomizations openXmlElement, Collection<DMW.KeyMapEntry>? value)
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
  
  public static DMW.KeyMapCustomizations? CreateModelElement(DXOW.KeyMapCustomizations? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.KeyMapCustomizations();
      value.KeyMapEntries = GetKeyMapEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.KeyMapCustomizations? openXmlElement, DMW.KeyMapCustomizations? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpKeyMapEntries(openXmlElement, value.KeyMapEntries, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.KeyMapCustomizations? value)
    where OpenXmlElementType: DXOW.KeyMapCustomizations, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetKeyMapEntries(openXmlElement, value?.KeyMapEntries);
      return openXmlElement;
    }
    return default;
  }
}
