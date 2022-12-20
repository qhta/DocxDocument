namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public partial interface Comments
{
  public Collection<DocumentModel.Wordprocessing.Comment>? Items { get; set; }
  
}
