namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal media reference relationship to a MediaDataPart element.
/// </summary>
[RelationshipUri("http://schemas.microsoft.com/office/2007/relationships/media")]
public interface MediaReferenceRelationship // : DocumentModel.Packaging.ReferenceRelationship
{
  /// <summary>
  /// Gets the relationship type for a media reference.
  /// </summary>
  public String? RelationshipType { get ; set; }
  
}
