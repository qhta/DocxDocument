namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the CommentsEx Class.
/// </summary>
public interface ICommentsEx // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.Word.ICommentEx>? CommentExs { get ; set; }
  
}
