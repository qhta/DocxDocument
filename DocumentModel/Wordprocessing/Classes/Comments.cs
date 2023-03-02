namespace DocumentModel.Wordprocessing;

/// <summary>
///   Comments Collection.
/// </summary>
public record Comments
{
  public Collection<Comment>? Items { get; set; }
}