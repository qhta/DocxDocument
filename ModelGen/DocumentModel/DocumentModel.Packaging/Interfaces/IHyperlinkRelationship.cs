namespace DocumentModel.Packaging;

/// <summary>
/// Represents a hyperlink relationship.
/// </summary>
public interface IHyperlinkRelationship // : DocumentModel.Packaging.IReferenceRelationship
{
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  public System.String? RelationshipType { get ; set; }
  
}
