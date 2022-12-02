namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentReplyList Class.
/// </summary>
public interface ICommentReplyList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICommentReply>? CommentReplies { get ; set; }
  
}
