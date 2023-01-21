namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public static class MismatchedKeyMapCustomizationConverter
{
  private static Collection<DMW.KeyMapEntry> GetKeyMapEntries(DXOW.MismatchedKeyMapCustomization openXmlElement)
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
  
  public static DMW.MismatchedKeyMapCustomization? CreateModelElement(DXOW.MismatchedKeyMapCustomization? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MismatchedKeyMapCustomization();
      value.KeyMapEntries = GetKeyMapEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MismatchedKeyMapCustomization? value)
    where OpenXmlElementType: DXOW.MismatchedKeyMapCustomization, new()
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
