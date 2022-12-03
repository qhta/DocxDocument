namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ThreadedCommentMentions Class.
/// </summary>
public interface ThreadedCommentMentions // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Mention>? Mentions { get ; set; }
  
}
