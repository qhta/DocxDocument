namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal audio reference relationship to a MediaDataPart element.
/// </summary>
public class AudioReferenceRelationshipImpl: DocumentModel.Packaging.ReferenceRelationshipImpl, AudioReferenceRelationship
{
  public new DocumentFormat.OpenXml.Packaging.AudioReferenceRelationship? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.AudioReferenceRelationship?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AudioReferenceRelationshipImpl(): base() {}
  
  public AudioReferenceRelationshipImpl(DocumentFormat.OpenXml.Packaging.AudioReferenceRelationship openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the relationship type for an audio reference.
  /// </summary>
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.AudioReferenceRelationship).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
