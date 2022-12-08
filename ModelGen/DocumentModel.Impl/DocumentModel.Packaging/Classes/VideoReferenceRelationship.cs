namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal video reference relationship to a MediaDataPart element.
/// </summary>
public class VideoReferenceRelationshipImpl: DocumentModel.Packaging.ReferenceRelationshipImpl, VideoReferenceRelationship
{
  public new DocumentFormat.OpenXml.Packaging.VideoReferenceRelationship? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VideoReferenceRelationship?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets the relationship type for a video reference.
  /// </summary>
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
