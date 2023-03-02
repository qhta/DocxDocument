namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetCommentsPart
/// </summary>
public record WorksheetCommentsPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}