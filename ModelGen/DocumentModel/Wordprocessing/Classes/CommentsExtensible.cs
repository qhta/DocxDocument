namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentsExtensible Class.
/// </summary>
public partial class CommentsExtensible
{
  public ExtensionList? ExtensionList { get; set; }
  
  public ElementCollection<CommentExtensible>? Items { get; set; }
  
}
