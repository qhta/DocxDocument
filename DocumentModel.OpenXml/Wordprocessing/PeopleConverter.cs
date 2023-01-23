namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the People Class.
/// </summary>
public static class PeopleConverter
{
  private static Collection<DMW.Person> GetPersons(DXO2013W.People openXmlElement)
  {
    var collection = new Collection<DMW.Person>();
    foreach (var item in openXmlElement.Elements<DXO2013W.Person>())
    {
      var newItem = DMXW.PersonConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpPersons(DXO2013W.People openXmlElement, Collection<DMW.Person>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetPersons(DXO2013W.People openXmlElement, Collection<DMW.Person>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013W.Person>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.PersonConverter.CreateOpenXmlElement<DXO2013W.Person>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.People? CreateModelElement(DXO2013W.People? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.People();
      value.Persons = GetPersons(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013W.People? openXmlElement, DMW.People? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPersons(openXmlElement, value.Persons, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.People? value)
    where OpenXmlElementType: DXO2013W.People, new()
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
