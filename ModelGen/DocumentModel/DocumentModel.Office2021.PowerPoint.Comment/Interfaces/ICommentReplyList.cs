namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentReplyList Class.
/// </summary>
public interface ICommentReplyList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2021.PowerPoint.Comment.ICommentReply>? CommentReplies { get ; set; }
  
}
