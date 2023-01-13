namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public static class KeyMapCustomizationsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.KeyMapEntry>? GetKeyMapEntries(DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.KeyMapEntry>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.KeyMapEntryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetKeyMapEntries(DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.KeyMapEntry>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.KeyMapEntryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.KeyMapCustomizations? CreateModelElement(DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations, new()
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
