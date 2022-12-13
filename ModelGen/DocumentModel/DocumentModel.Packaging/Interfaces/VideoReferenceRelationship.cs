namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal video reference relationship to a MediaDataPart element.
/// </summary>
public interface VideoReferenceRelationship
{
  /// <summary>
  /// Gets the relationship type for a video reference.
  /// </summary>
  public String? RelationshipType { get ; set; }
  
}
