namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentExtensionList Class.
/// </summary>
public interface CommentExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<CommentExtension>? CommentExtensions { get ; set; }
  
}
