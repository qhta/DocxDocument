namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentExtensionList Class.
/// </summary>
public interface ICommentExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ICommentExtension>? CommentExtensions { get ; set; }
  
}
