namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public interface ICommentsExtensible // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ICommentExtensible>? CommentExtensibles { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
