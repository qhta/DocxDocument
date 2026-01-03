namespace DocumentModel;

/// <summary>
///   Represents a single historical event that records a change or action performed on a task.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and captures detailed information about
///   task-related events such as creation, assignment, scheduling changes, priority updates,
///   and deletions. Each event includes attribution, timing, and specific event details.
/// </remarks>
public interface TaskHistoryEvent : IModelElement
{
  /// <summary>
  ///   Gets or sets the timestamp when the task event occurred.
  /// </summary>
  public DateTime? Time { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this task history event.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the user who is attributed as the source of this event.
  /// </summary>
  public OpenXmlTaskUserElement? AttributionTaskUser { get; set; }

  /// <summary>
  ///   Gets or sets the anchor that links this event to a specific location in the document.
  /// </summary>
  public TaskAnchor? TaskAnchor { get; set; }

  /// <summary>
  ///   Gets or sets the user to whom the task was assigned in this event.
  /// </summary>
  public OpenXmlTaskUserElement? AssignTaskUser { get; set; }

  /// <summary>
  ///   Gets or sets the user from whom the task was unassigned in this event.
  /// </summary>
  public OpenXmlTaskUserElement? UnassignTaskUser { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this event represents a task creation.
  /// </summary>
  public bool? TaskCreateEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets the information about a task title change event.
  /// </summary>
  public TaskTitleEventInfo? TaskTitleEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets the information about a task schedule change event.
  /// </summary>
  public TaskScheduleEventInfo? TaskScheduleEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets the information about a task progress change event.
  /// </summary>
  public TaskProgressEventInfo? TaskProgressEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets the information about a task priority change event.
  /// </summary>
  public TaskPriorityEventInfo? TaskPriorityEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this event represents a task deletion.
  /// </summary>
  public bool? TaskDeleteEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this event represents a task undeletion (restoration).
  /// </summary>
  public bool? TaskUndeleteEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this event represents unassigning all users from the task.
  /// </summary>
  public bool? TaskUnassignAll { get; set; }

  /// <summary>
  ///   Gets or sets the information about an undo operation performed on the task.
  /// </summary>
  public TaskUndo? TaskUndo { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}