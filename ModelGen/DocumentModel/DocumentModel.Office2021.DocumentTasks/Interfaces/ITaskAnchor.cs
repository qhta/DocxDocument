namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public interface ITaskAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.ICommentAnchor? CommentAnchor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.IExtensionList? ExtensionList { get ; set; }
  
}
