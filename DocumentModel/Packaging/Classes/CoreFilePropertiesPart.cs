namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CoreFilePropertiesPart
/// </summary>
public record CoreFilePropertiesPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}