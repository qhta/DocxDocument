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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
