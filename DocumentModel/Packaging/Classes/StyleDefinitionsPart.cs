namespace DocumentModel.Packaging;

/// <summary>
///   Defines the StyleDefinitionsPart
/// </summary>
public record StyleDefinitionsPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}