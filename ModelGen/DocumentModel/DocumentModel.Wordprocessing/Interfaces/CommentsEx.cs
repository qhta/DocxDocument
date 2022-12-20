namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsEx Class.
/// </summary>
public partial interface CommentsEx
{
  /// <summary>
  /// Gets the WordprocessingCommentsExPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsExPart? WordprocessingCommentsExPart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.CommentEx>? CommentExs { get; set; }
  
}
