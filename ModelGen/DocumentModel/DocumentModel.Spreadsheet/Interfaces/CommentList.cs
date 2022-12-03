namespace DocumentModel.Spreadsheet;

/// <summary>
/// List of Comments.
/// </summary>
public interface CommentList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Comment>? Comments { get ; set; }
  
}
