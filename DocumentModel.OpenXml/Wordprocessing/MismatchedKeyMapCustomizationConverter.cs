namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public static class MismatchedKeyMapCustomizationConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.KeyMapEntry>? GetKeyMapEntries(DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization? openXmlElement)
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
  
  public static void SetKeyMapEntries(DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.KeyMapEntry>? value)
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
  
  public static DocumentModel.Wordprocessing.MismatchedKeyMapCustomization? CreateModelElement(DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
