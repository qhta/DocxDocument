namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetThreadedCommentsPart
/// </summary>
public interface WorksheetThreadedCommentsPart:
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}