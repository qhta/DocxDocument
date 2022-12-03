namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideCommentsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.presentationml.comments+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments")]
public interface SlideCommentsPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.CommentList? CommentList { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
