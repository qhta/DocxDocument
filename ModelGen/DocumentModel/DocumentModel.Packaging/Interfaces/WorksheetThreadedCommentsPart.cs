namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetThreadedCommentsPart
/// </summary>
[ContentMime("application/vnd.ms-excel.threadedcomments+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2017/10/relationships/threadedComment")]
public interface WorksheetThreadedCommentsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.ThreadedComments? ThreadedComments { get ; set; }
  
}
