namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.commentsExtensible+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2018/08/relationships/commentsExtensible")]
public interface WordCommentsExtensiblePart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsExtensible? CommentsExtensible { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
