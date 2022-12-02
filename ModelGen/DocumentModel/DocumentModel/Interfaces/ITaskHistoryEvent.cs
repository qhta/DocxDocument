namespace DocumentModel;

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
  public DocumentModel.IOpenXmlTaskUserElement? AttributionTaskUser { get ; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.ITaskAnchor? TaskAnchor { get ; set; }
  
  public DocumentModel.IOpenXmlTaskUserElement? AssignTaskUser { get ; set; }
  
  public DocumentModel.IOpenXmlTaskUserElement? UnassignTaskUser { get ; set; }
  
  public System.Boolean? TaskCreateEventInfo { get ; set; }
  
  public DocumentModel.ITaskTitleEventInfo? TaskTitleEventInfo { get ; set; }
  
  public DocumentModel.ITaskScheduleEventInfo? TaskScheduleEventInfo { get ; set; }
  
  public DocumentModel.ITaskProgressEventInfo? TaskProgressEventInfo { get ; set; }
  
  public DocumentModel.ITaskPriorityEventInfo? TaskPriorityEventInfo { get ; set; }
  
  public System.Boolean? TaskDeleteEventInfo { get ; set; }
  
  public System.Boolean? TaskUndeleteEventInfo { get ; set; }
  
  public System.Boolean? TaskUnassignAll { get ; set; }
  
  public DocumentModel.ITaskUndo? TaskUndo { get ; set; }
  
  public DocumentModel.IExtensionList? ExtensionList { get ; set; }
  
}
