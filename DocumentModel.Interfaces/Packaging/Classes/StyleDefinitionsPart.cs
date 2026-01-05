namespace DocumentModel.Packaging;

/// <summary>
///   Defines the StyleDefinitionsPart
/// </summary>
public interface StyleDefinitionsPart:
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}