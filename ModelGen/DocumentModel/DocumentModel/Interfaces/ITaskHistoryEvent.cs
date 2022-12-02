namespace DocumentModel;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public interface ITaskHistoryEvent // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  public IOpenXmlTaskUserElement? AttributionTaskUser { get ; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public ITaskAnchor? TaskAnchor { get ; set; }
  
  public IOpenXmlTaskUserElement? AssignTaskUser { get ; set; }
  
  public IOpenXmlTaskUserElement? UnassignTaskUser { get ; set; }
  
  public Boolean? TaskCreateEventInfo { get ; set; }
  
  public ITaskTitleEventInfo? TaskTitleEventInfo { get ; set; }
  
  public ITaskScheduleEventInfo? TaskScheduleEventInfo { get ; set; }
  
  public ITaskProgressEventInfo? TaskProgressEventInfo { get ; set; }
  
  public ITaskPriorityEventInfo? TaskPriorityEventInfo { get ; set; }
  
  public Boolean? TaskDeleteEventInfo { get ; set; }
  
  public Boolean? TaskUndeleteEventInfo { get ; set; }
  
  public Boolean? TaskUnassignAll { get ; set; }
  
  public ITaskUndo? TaskUndo { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
