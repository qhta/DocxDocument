namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal video reference relationship to a MediaDataPart element.
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video")]
public interface VideoReferenceRelationship // : DocumentModel.Packaging.ReferenceRelationship
{
  /// <summary>
  /// Gets the relationship type for a video reference.
  /// </summary>
  public String? RelationshipType { get ; set; }
  
}
