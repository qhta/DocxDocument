namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetCommentsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.comments+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments")]
public interface WorksheetCommentsPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.Comments? Comments { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
