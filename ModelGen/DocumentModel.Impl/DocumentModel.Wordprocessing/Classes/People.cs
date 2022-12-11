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
  
  public PeopleImpl(): base() {}
  
  public PeopleImpl(DocumentFormat.OpenXml.Office2013.Word.People openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Person>? Persons
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
