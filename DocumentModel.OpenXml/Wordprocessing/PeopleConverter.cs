using DocumentModel.Wordprocessing;
using People = DocumentFormat.OpenXml.Office2013.Word.People;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the People Class.
/// </summary>
public static class PeopleConverter
{
  public static Collection<Person>? GetPersons(People? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Person>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Word.Person>())
      {
        var newItem = PersonConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPersons(People? openXmlElement, Collection<Person>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Word.Person>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PersonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.Person>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.People? CreateModelElement(People? openXmlElement)
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
    where OpenXmlElementType : People, new()
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