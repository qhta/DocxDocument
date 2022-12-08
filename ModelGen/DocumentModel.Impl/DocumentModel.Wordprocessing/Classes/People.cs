namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the People Class.
/// </summary>
public class PeopleImpl: ModelElementImpl, People
{
  public DocumentFormat.OpenXml.Office2013.Word.People? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.People?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Person>? Persons
  {
    get;
    set;
  }
  
}
