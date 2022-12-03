namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentReplyList Class.
/// </summary>
public interface CommentReplyList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<CommentReply>? CommentReplies { get ; set; }
  
}
