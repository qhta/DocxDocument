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
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.People? People
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
