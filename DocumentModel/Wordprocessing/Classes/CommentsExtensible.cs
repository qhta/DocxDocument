namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CommentsExtensible Class.
/// </summary>
public class CommentsExtensible: ModelElement
{
  public Collection<CommentExtensible>? CommentExtensibles { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}