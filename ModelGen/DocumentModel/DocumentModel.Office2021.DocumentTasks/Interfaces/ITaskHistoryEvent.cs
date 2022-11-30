namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public interface ITaskHistoryEvent // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? Time { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.IOpenXmlTaskUserElement? AttributionTaskUser { get ; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.ITaskAnchor? TaskAnchor { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.IOpenXmlTaskUserElement? AssignTaskUser { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.IOpenXmlTaskUserElement? UnassignTaskUser { get ; set; }
  
  public System.Boolean? TaskCreateEventInfo { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.ITaskTitleEventInfo? TaskTitleEventInfo { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.ITaskScheduleEventInfo? TaskScheduleEventInfo { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.ITaskProgressEventInfo? TaskProgressEventInfo { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.ITaskPriorityEventInfo? TaskPriorityEventInfo { get ; set; }
  
  public System.Boolean? TaskDeleteEventInfo { get ; set; }
  
  public System.Boolean? TaskUndeleteEventInfo { get ; set; }
  
  public System.Boolean? TaskUnassignAll { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.ITaskUndo? TaskUndo { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.IExtensionList? ExtensionList { get ; set; }
  
}
