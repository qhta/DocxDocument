namespace DocumentModel;

/// <summary>
/// Defines the Task Class.
/// </summary>
public class TaskImpl: ModelElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.Task>, Task
{
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public TaskAnchor? TaskAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public TaskHistory? TaskHistory
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
