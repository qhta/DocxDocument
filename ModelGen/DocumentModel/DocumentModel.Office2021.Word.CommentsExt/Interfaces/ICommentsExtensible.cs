namespace DocumentModel.Office2021.Word.CommentsExt;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public interface ICommentsExtensible // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2021.Word.CommentsExt.ICommentExtensible>? CommentExtensibles { get ; set; }
  
  public DocumentModel.Office2021.Word.CommentsExt.IExtensionList? ExtensionList { get ; set; }
  
}
