namespace DocumentModel;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public class TaskHistoryEventImpl: ModelElementImpl, TaskHistoryEvent
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  public OpenXmlTaskUserElement? AttributionTaskUser
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
  
  public OpenXmlTaskUserElement? AssignTaskUser
  {
    get;
    set;
  }
  
  public OpenXmlTaskUserElement? UnassignTaskUser
  {
    get;
    set;
  }
  
  public Boolean? TaskCreateEventInfo
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
  
  public Boolean? TaskDeleteEventInfo
  {
    get;
    set;
  }
  
  public Boolean? TaskUndeleteEventInfo
  {
    get;
    set;
  }
  
  public Boolean? TaskUnassignAll
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
