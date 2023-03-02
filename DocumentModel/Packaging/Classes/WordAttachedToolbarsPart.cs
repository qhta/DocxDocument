namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordAttachedToolbarsPart
/// </summary>
public record WordAttachedToolbarsPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}