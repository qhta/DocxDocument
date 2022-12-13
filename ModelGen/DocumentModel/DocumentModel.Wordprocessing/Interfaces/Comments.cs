namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public interface Comments
{
  public Collection<DocumentModel.Wordprocessing.Comment>? Items { get ; set; }
  
}
