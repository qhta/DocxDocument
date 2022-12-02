namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentExtensionList Class.
/// </summary>
public interface ICommentExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICommentExtension>? CommentExtensions { get ; set; }
  
}
