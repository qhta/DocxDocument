namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public static class FontsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Font>? GetItems(DocumentFormat.OpenXml.Wordprocessing.Fonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Font>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Font>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.FontConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Wordprocessing.Fonts? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Font>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Font>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.FontConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Font>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Fonts? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Fonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Fonts();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Fonts? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Fonts, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
