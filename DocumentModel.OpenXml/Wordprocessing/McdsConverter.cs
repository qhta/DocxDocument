namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Mcds Class.
/// </summary>
public static class McdsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Mcd>? GetItems(DocumentFormat.OpenXml.Office.Word.Mcds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Mcd>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.Mcd>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.McdConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office.Word.Mcds? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Mcd>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.Mcd>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.McdConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.Mcd>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Mcds? CreateModelElement(DocumentFormat.OpenXml.Office.Word.Mcds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Mcds();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Mcds? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.Mcds, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
