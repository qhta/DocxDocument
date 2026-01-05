namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedObjectPart
/// </summary>
public interface EmbeddedObjectPart:
{
  public string? RelationshipType { get; set; }
}