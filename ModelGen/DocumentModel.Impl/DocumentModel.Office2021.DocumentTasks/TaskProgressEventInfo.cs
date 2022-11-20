namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public class TaskProgressEventInfo: ITaskProgressEventInfo
{
  /// <summary>
  /// percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  public int? PercentComplete
  {
    get;
    set;
  }
  
}
