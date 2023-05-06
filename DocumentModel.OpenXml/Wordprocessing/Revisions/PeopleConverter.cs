namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the People Class.
/// </summary>
public static class PeopleConverter
{
  private static Collection<DMW.Person>? GetPersons(DXO13W.People openXmlElement)
  {
    var collection = new Collection<DMW.Person>();
    foreach (var item in openXmlElement.Elements<DXO13W.Person>())
    {
      var newItem = DMXW.PersonConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPersons(DXO13W.People openXmlElement, Collection<DMW.Person>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO13W.Person>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.PersonConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPersons(DXO13W.People openXmlElement, Collection<DMW.Person>? value)
  {
    openXmlElement.RemoveAllChildren<DXO13W.Person>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.PersonConverter.CreateOpenXmlElement<DXO13W.Person>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMW.People? CreateModelElement(DXO13W.People? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.People();
      value.Persons = GetPersons(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13W.People? openXmlElement, DMW.People? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPersons(openXmlElement, value.Persons, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.People value)
    where OpenXmlElementType: DXO13W.People, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13W.People openXmlElement, DMW.People value)
  {
    SetPersons(openXmlElement, value?.Persons);
  }
}
