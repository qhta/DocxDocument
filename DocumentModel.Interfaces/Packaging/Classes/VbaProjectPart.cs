namespace DocumentModel.Packaging;

/// <summary>
///   Defines the VbaProjectPart
/// </summary>
public interface VbaProjectPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}