namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CommentsEx Class.
/// </summary>
public class CommentsEx: ModelElement
{
  public Collection<CommentEx>? CommentExs { get; set; }
}