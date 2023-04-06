namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Comments Collection.
/// </summary>
public class Comments: ModelElement
{
  public Collection<Comment>? Items { get; set; }
}