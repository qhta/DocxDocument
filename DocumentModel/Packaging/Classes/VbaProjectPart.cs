namespace DocumentModel.Packaging;

/// <summary>
///   Defines the VbaProjectPart
/// </summary>
public record VbaProjectPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}