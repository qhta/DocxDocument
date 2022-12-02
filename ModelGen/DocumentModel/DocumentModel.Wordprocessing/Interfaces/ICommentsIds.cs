namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsIds Class.
/// </summary>
public interface ICommentsIds // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ICommentId>? CommentIds { get ; set; }
  
}
