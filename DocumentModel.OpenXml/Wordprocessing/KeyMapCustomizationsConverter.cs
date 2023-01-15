using DocumentModel.Wordprocessing;
using KeyMapCustomizations = DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the KeyMapCustomizations Class.
/// </summary>
public static class KeyMapCustomizationsConverter
{
  public static Collection<KeyMapEntry>? GetKeyMapEntries(KeyMapCustomizations? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<KeyMapEntry>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>())
      {
        var newItem = KeyMapEntryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetKeyMapEntries(KeyMapCustomizations? openXmlElement, Collection<KeyMapEntry>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = KeyMapEntryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.KeyMapCustomizations? CreateModelElement(KeyMapCustomizations? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.KeyMapCustomizations();
      value.KeyMapEntries = GetKeyMapEntries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.KeyMapCustomizations? value)
    where OpenXmlElementType : KeyMapCustomizations, new()
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