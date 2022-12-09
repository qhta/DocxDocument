namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RelationshipType Class.
/// </summary>
public class RelationshipTypeImpl: ModelElementImpl, RelationshipType
{
  public DocumentFormat.OpenXml.Wordprocessing.RelationshipType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RelationshipType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
