namespace DocumentModel;


/// <summary>
///   Defines the TaskHistoryEvent Class.
/// </summary>
public partial class TaskHistoryEvent
{
  
  /// <summary>
  ///   time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time { get; set; }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   AttributionTaskUser.
  /// </summary>
  public DM.AttributionTaskUser? AttributionTaskUser { get; set; }
  
  
  /// <summary>
  ///   TaskAnchor.
  /// </summary>
  public DM.TaskAnchor? TaskAnchor { get; set; }
  
  public DM.AssignTaskUser? AssignTaskUser { get; set; }
  
  public DM.UnassignTaskUser? UnassignTaskUser { get; set; }
  
  public DM.TaskCreateEventInfo? TaskCreateEventInfo { get; set; }
  
  public DM.TaskTitleEventInfo? TaskTitleEventInfo { get; set; }
  
  public DM.TaskScheduleEventInfo? TaskScheduleEventInfo { get; set; }
  
  public DM.TaskProgressEventInfo? TaskProgressEventInfo { get; set; }
  
  public DM.TaskPriorityEventInfo? TaskPriorityEventInfo { get; set; }
  
  public DM.TaskDeleteEventInfo? TaskDeleteEventInfo { get; set; }
  
  public DM.TaskUndeleteEventInfo? TaskUndeleteEventInfo { get; set; }
  
  public DM.TaskUnassignAll? TaskUnassignAll { get; set; }
  
  public DM.TaskUndo? TaskUndo { get; set; }
  
  public DM.ExtensionList? ExtensionList { get; set; }
  
}
