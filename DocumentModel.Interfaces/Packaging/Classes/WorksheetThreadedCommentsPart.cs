namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetThreadedCommentsPart
/// </summary>
public interface WorksheetThreadedCommentsPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}