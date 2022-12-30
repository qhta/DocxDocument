namespace DocumentModel;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public partial class TaskHistoryEvent
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time { get; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  public DocumentModel.OpenXmlTaskUserElement? AttributionTaskUser { get; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.TaskAnchor? TaskAnchor { get; set; }
  
  public DocumentModel.OpenXmlTaskUserElement? AssignTaskUser { get; set; }
  
  public DocumentModel.OpenXmlTaskUserElement? UnassignTaskUser { get; set; }
  
  public Boolean? TaskCreateEventInfo { get; set; }
  
  public DocumentModel.TaskTitleEventInfo? TaskTitleEventInfo { get; set; }
  
  public DocumentModel.TaskScheduleEventInfo? TaskScheduleEventInfo { get; set; }
  
  public DocumentModel.TaskProgressEventInfo? TaskProgressEventInfo { get; set; }
  
  public DocumentModel.TaskPriorityEventInfo? TaskPriorityEventInfo { get; set; }
  
  public Boolean? TaskDeleteEventInfo { get; set; }
  
  public Boolean? TaskUndeleteEventInfo { get; set; }
  
  public Boolean? TaskUnassignAll { get; set; }
  
  public DocumentModel.TaskUndo? TaskUndo { get; set; }
  
  public DocumentModel.ExtensionList? ExtensionList { get; set; }
  
}
