namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetCommentsPart
/// </summary>
public interface WorksheetCommentsPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}