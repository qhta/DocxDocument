namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PowerPointCommentPart
/// </summary>
[ContentMime("application/vnd.ms-powerpoint.comments+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2018/10/relationships/comments")]
public interface PowerPointCommentPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.CommentList? CommentList { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
