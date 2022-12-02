namespace DocumentModel;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public interface ITaskAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public ICommentAnchor? CommentAnchor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
