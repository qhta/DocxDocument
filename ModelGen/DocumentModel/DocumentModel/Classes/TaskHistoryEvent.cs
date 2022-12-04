namespace DocumentModel;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public class TaskHistoryEvent
{
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  public Boolean? AttributionTaskUser
  {
    get;
    set;
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public TaskAnchor? TaskAnchor
  {
    get;
    set;
  }
  
  public TaskTitleEventInfo? TaskTitleEventInfo
  {
    get;
    set;
  }
  
  public TaskScheduleEventInfo? TaskScheduleEventInfo
  {
    get;
    set;
  }
  
  public TaskProgressEventInfo? TaskProgressEventInfo
  {
    get;
    set;
  }
  
  public TaskPriorityEventInfo? TaskPriorityEventInfo
  {
    get;
    set;
  }
  
  public TaskUndo? TaskUndo
  {
    get;
    set;
  }
  
  public ExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
