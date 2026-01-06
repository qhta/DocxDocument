namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetCommentsPart
/// </summary>
public interface WorksheetCommentsPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}