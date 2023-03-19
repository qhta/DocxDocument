namespace DocumentModel.Wordprocessing;

/// <summary>
///   Comments Collection.
/// </summary>
public class Comments: ModelElement
{
  public Collection<Comment>? Items { get; set; }
}