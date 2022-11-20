namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskTitleEventInfo Class.
/// </summary>
public class TaskTitleEventInfo: ITaskTitleEventInfo
{
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Title
  {
    get;
    set;
  }
  
}
