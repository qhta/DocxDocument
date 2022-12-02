namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public interface ICommentsExtensible // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ICommentExtensible>? CommentExtensibles { get ; set; }
  
  public DocumentModel.Wordprocessing.IExtensionList? ExtensionList { get ; set; }
  
}
