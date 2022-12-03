namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public interface Comments // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Comment>? Comments { get ; set; }
  
}
