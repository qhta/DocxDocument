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
  
  public VideoReferenceRelationshipImpl(): base() {}
  
  public VideoReferenceRelationshipImpl(DocumentFormat.OpenXml.Packaging.VideoReferenceRelationship openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the relationship type for a video reference.
  /// </summary>
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.VideoReferenceRelationship).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
