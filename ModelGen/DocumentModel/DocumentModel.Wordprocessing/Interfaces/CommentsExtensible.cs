namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public partial interface CommentsExtensible
{
  public Collection<DocumentModel.Wordprocessing.CommentExtensible>? CommentExtensibles { get; set; }
  
  public DocumentModel.Wordprocessing.ExtensionList? ExtensionList { get; set; }
  
}
