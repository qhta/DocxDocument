namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PowerPointCommentPart
/// </summary>
public interface PowerPointCommentPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}