namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CommentsExtensible Class.
/// </summary>
public record CommentsExtensible
{
  public Collection<CommentExtensible>? CommentExtensibles { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}