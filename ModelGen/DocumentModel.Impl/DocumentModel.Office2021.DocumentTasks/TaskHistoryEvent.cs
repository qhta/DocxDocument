namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskAnchor))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskCreateEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskDeleteEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskPriorityEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskProgressEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskScheduleEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskTitleEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskUnassignAll))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskUndeleteEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.ITaskUndo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.IAttributionTaskUser))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.IAssignTaskUser))]
[ChildElementInfo(typeof(DocumentModel.Office2021.DocumentTasks.IUnassignTaskUser))]
public class TaskHistoryEvent: ITaskHistoryEvent
{
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
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  public IAttributionTaskUser? AttributionTaskUser
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
  
}
