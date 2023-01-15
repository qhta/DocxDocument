using DocumentModel.Wordprocessing;
using MismatchedKeyMapCustomization = DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public static class MismatchedKeyMapCustomizationConverter
{
  public static Collection<KeyMapEntry>? GetKeyMapEntries(MismatchedKeyMapCustomization? openXmlElement)
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

  public static void SetKeyMapEntries(MismatchedKeyMapCustomization? openXmlElement, Collection<KeyMapEntry>? value)
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

  public static DocumentModel.Wordprocessing.MismatchedKeyMapCustomization? CreateModelElement(MismatchedKeyMapCustomization? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MismatchedKeyMapCustomization();
      value.KeyMapEntries = GetKeyMapEntries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MismatchedKeyMapCustomization? value)
    where OpenXmlElementType : MismatchedKeyMapCustomization, new()
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