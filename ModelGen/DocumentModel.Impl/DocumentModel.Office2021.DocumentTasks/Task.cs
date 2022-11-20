namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the Task Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskAnchor))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskHistory))]
public class Task: ITask
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.ITaskAnchor? TaskAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.ITaskHistory? TaskHistory
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
