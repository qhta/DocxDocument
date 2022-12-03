namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentList Class.
/// </summary>
public interface CommentList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Comment>? Comments { get ; set; }
  
}
