namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the People Class.
/// </summary>
public static class PeopleConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Person>? GetPersons(DocumentFormat.OpenXml.Office2013.Word.People? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Person>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Word.Person>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.PersonConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetPersons(DocumentFormat.OpenXml.Office2013.Word.People? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Person>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Word.Person>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.PersonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.Person>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.People? CreateModelElement(DocumentFormat.OpenXml.Office2013.Word.People? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.People();
      value.Persons = GetPersons(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.People? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Word.People, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPersons(openXmlElement, value?.Persons);
      return openXmlElement;
    }
    return default;
  }
}
