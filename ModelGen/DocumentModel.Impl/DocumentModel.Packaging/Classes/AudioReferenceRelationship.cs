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
  
  /// <summary>
  /// Gets the relationship type for an audio reference.
  /// </summary>
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
