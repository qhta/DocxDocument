namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordAttachedToolbarsPart
/// </summary>
public interface WordAttachedToolbarsPart:
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}