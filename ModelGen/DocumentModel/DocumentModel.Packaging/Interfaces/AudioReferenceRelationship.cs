namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal audio reference relationship to a MediaDataPart element.
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio")]
public interface AudioReferenceRelationship // : DocumentModel.Packaging.ReferenceRelationship
{
  /// <summary>
  /// Gets the relationship type for an audio reference.
  /// </summary>
  public String? RelationshipType { get ; set; }
  
}
