namespace DocumentModel.Packaging;

/// <summary>
/// Represents a hyperlink relationship.
/// </summary>
public interface HyperlinkRelationship // : DocumentModel.Packaging.ReferenceRelationship
{
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  public String? RelationshipType { get ; set; }
  
}
