namespace DocumentModel;

/// <summary>
///   Defines the TaskHistoryEvent Class.
/// </summary>
public class TaskHistoryEvent: ModelElement
{
  /// <summary>
  ///   time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time { get; set; }
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   AttributionTaskUser.
  /// </summary>
  public OpenXmlTaskUserElement? AttributionTaskUser { get; set; }
  /// <summary>
  ///   TaskAnchor.
  /// </summary>
  public TaskAnchor? TaskAnchor { get; set; }
  public OpenXmlTaskUserElement? AssignTaskUser { get; set; }
  public OpenXmlTaskUserElement? UnassignTaskUser { get; set; }
  public bool? TaskCreateEventInfo { get; set; }
  public TaskTitleEventInfo? TaskTitleEventInfo { get; set; }
  public TaskScheduleEventInfo? TaskScheduleEventInfo { get; set; }
  public TaskProgressEventInfo? TaskProgressEventInfo { get; set; }
  public TaskPriorityEventInfo? TaskPriorityEventInfo { get; set; }
  public bool? TaskDeleteEventInfo { get; set; }
  public bool? TaskUndeleteEventInfo { get; set; }
  public bool? TaskUnassignAll { get; set; }
  public TaskUndo? TaskUndo { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}