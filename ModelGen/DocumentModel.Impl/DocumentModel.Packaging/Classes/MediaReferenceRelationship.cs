namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal media reference relationship to a MediaDataPart element.
/// </summary>
public class MediaReferenceRelationshipImpl: DocumentModel.Packaging.ReferenceRelationshipImpl, MediaReferenceRelationship
{
  public new DocumentFormat.OpenXml.Packaging.MediaReferenceRelationship? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.MediaReferenceRelationship?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MediaReferenceRelationshipImpl(): base() {}
  
  public MediaReferenceRelationshipImpl(DocumentFormat.OpenXml.Packaging.MediaReferenceRelationship openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the relationship type for a media reference.
  /// </summary>
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.MediaReferenceRelationship).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
