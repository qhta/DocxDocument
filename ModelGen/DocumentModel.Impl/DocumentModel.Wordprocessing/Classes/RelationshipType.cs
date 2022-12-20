namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RelationshipType Class.
/// </summary>
public partial class RelationshipTypeImpl: ModelElementImpl, RelationshipType
{
  public DocumentFormat.OpenXml.Wordprocessing.RelationshipType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RelationshipType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RelationshipTypeImpl(): base() {}
  
  public RelationshipTypeImpl(DocumentFormat.OpenXml.Wordprocessing.RelationshipType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
