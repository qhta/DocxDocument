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
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
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
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
