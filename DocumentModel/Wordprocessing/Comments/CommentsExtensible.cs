namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CommentsExtensible Class.
/// </summary>
public class CommentsExtensible: ModelElement
{
  public Collection<CommentExtensible>? CommentExtensibles { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}