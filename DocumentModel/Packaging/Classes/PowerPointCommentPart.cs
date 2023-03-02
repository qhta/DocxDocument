namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PowerPointCommentPart
/// </summary>
public record PowerPointCommentPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}