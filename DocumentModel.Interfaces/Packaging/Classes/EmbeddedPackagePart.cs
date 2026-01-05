namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedPackagePart
/// </summary>
public interface EmbeddedPackagePart:
{
  public string? RelationshipType { get; set; }
}