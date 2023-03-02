namespace DocumentModel.Packaging;

/// <summary>
///   Represents a hyperlink relationship.
/// </summary>
public record HyperlinkRelationship
{
  /// <summary>
  ///   Gets the relationship type.
  /// </summary>
  public String? RelationshipType { get; set; }
}