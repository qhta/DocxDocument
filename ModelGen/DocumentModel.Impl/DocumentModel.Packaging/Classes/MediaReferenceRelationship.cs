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
  
  /// <summary>
  /// Gets the relationship type for a media reference.
  /// </summary>
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
