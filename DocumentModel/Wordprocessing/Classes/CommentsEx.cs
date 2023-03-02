namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CommentsEx Class.
/// </summary>
public record CommentsEx
{
  public Collection<CommentEx>? CommentExs { get; set; }
}