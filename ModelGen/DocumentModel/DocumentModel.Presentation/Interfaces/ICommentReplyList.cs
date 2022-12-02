namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentReplyList Class.
/// </summary>
public interface ICommentReplyList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ICommentReply>? CommentReplies { get ; set; }
  
}
