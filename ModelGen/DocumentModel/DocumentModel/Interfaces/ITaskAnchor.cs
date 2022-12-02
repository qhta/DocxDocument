namespace DocumentModel;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public interface ITaskAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.ICommentAnchor? CommentAnchor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.IExtensionList? ExtensionList { get ; set; }
  
}
