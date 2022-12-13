namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal media reference relationship to a MediaDataPart element.
/// </summary>
public interface MediaReferenceRelationship
{
  /// <summary>
  /// Gets the relationship type for a media reference.
  /// </summary>
  public String? RelationshipType { get ; set; }
  
}
