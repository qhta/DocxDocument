namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPeoplePart
/// </summary>
public class WordprocessingPeoplePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WordprocessingPeoplePart
{
  public new DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WordprocessingPeoplePartImpl(): base() {}
  
  public WordprocessingPeoplePartImpl(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.People? People
  {
    get
    {
      if (OpenXmlElement?.People != null)
        return new DocumentModel.Wordprocessing.PeopleImpl(OpenXmlElement.People);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.PeopleImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.People = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
