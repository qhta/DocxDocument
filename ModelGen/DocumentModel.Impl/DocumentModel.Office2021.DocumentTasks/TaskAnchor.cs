namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ICommentAnchor))]
public class TaskAnchor: ITaskAnchor
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.ICommentAnchor? CommentAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
