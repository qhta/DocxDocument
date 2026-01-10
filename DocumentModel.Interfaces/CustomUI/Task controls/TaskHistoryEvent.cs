namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a single historical event that records a change or action performed on a task, supporting detailed attribution, event type, and extensibility for advanced task management scenarios.
/// </summary>
/// <remarks>
/// This interface captures information about task-related events such as creation, assignment, scheduling changes, priority updates, deletions, and undo operations. Each event includes attribution, timing, and event-specific details, supporting advanced workflows for task tracking, auditing, and integration in Office add-ins or document solutions.
/// </remarks>
public interface TaskHistoryEvent : IdentifiedElement, CollectionItem, ExtendableElement
{
  /// <summary>
  /// Timestamp when the task event occurred.
  /// </summary>
  public DateTime? Time { get; set; }

  /// <summary>
  /// User attributed as the source of this event.
  /// </summary>
  public OpenXmlTaskUserElement? AttributionTaskUser { get; set; }

  /// <summary>
  /// Anchor that links this event to a specific location in the document.
  /// </summary>
  public TaskAnchor? TaskAnchor { get; set; }

  /// <summary>
  /// User to whom the task was assigned in this event.
  /// </summary>
  public OpenXmlTaskUserElement? AssignTaskUser { get; set; }

  /// <summary>
  /// User from whom the task was unassigned in this event.
  /// </summary>
  public OpenXmlTaskUserElement? UnassignTaskUser { get; set; }

  /// <summary>
  /// Indicates whether this event represents a task creation.
  /// </summary>
  public bool? TaskCreateEventInfo { get; set; }

  /// <summary>
  /// Information about a task title change event.
  /// </summary>
  public TaskTitleEventInfo? TaskTitleEventInfo { get; set; }

  /// <summary>
  /// Information about a task schedule change event.
  /// </summary>
  public TaskScheduleEventInfo? TaskScheduleEventInfo { get; set; }

  /// <summary>
  /// Information about a task progress change event.
  /// </summary>
  public TaskProgressEventInfo? TaskProgressEventInfo { get; set; }

  /// <summary>
  /// Information about a task priority change event.
  /// </summary>
  public TaskPriorityEventInfo? TaskPriorityEventInfo { get; set; }

  /// <summary>
  /// Indicates whether this event represents a task deletion.
  /// </summary>
  public bool? TaskDeleteEventInfo { get; set; }

  /// <summary>
  /// Indicates whether this event represents a task undeletion (restoration).
  /// </summary>
  public bool? TaskUndeleteEventInfo { get; set; }

  /// <summary>
  /// Indicates whether this event represents unassigning all users from the task.
  /// </summary>
  public bool? TaskUnassignAll { get; set; }

  /// <summary>
  /// Information about an undo operation performed on the task.
  /// </summary>
  public TaskUndo? TaskUndo { get; set; }

}