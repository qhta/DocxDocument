namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal audio reference relationship to a MediaDataPart element.
/// </summary>
public interface AudioReferenceRelationship
{
  /// <summary>
  /// Gets the relationship type for an audio reference.
  /// </summary>
  public String? RelationshipType { get ; set; }
  
}
