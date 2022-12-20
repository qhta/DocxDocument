namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsIds Class.
/// </summary>
public partial interface CommentsIds
{
  /// <summary>
  /// Gets the WordprocessingCommentsIdsPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsIdsPart? WordprocessingCommentsIdsPart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.CommentId>? CommentIds { get; set; }
  
}
