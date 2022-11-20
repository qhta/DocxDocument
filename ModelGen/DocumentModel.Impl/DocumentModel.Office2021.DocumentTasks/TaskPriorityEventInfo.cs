namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskPriorityEventInfo Class.
/// </summary>
public class TaskPriorityEventInfo: ITaskPriorityEventInfo
{
  /// <summary>
  /// value, this property is only available in Office 2021 and later.
  /// </summary>
  public int? Value
  {
    get;
    set;
  }
  
}
