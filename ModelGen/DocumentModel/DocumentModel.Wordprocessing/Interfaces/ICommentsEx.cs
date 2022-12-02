namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsEx Class.
/// </summary>
public interface ICommentsEx // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ICommentEx>? CommentExs { get ; set; }
  
}
