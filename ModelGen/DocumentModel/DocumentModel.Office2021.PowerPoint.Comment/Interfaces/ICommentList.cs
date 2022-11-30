namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentList Class.
/// </summary>
public interface ICommentList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2021.PowerPoint.Comment.IComment>? Comments { get ; set; }
  
}
