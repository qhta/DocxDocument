namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentsExtensible Class.
/// </summary>
public partial class CommentsExtensible
{
  public DocumentModel.Wordprocessing.ExtensionList? ExtensionList { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.CommentExtensible>? Items { get; set; }
  
}
