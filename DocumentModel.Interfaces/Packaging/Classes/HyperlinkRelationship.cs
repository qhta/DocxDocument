namespace DocumentModel.Packaging;

/// <summary>
///   Represents a hyperlink relationship.
/// </summary>
public interface HyperlinkRelationship: IModelElement
{
  /// <summary>
  ///   Gets the relationship type.
  /// </summary>
  public string? RelationshipType { get; set; }
}