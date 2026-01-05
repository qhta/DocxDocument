namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideCommentsPart
/// </summary>
public interface SlideCommentsPart:
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}