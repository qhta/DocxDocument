namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public partial interface CommentsExtensible
{
  /// <summary>
  /// Gets the WordCommentsExtensiblePart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WordCommentsExtensiblePart? WordCommentsExtensiblePart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.CommentExtensible>? CommentExtensibles { get; set; }
  
  public DocumentModel.Wordprocessing.ExtensionList? ExtensionList { get; set; }
  
}
