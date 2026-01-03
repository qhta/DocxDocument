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
  /// <value>
  ///   A <see cref="DateTime"/> value representing when the event took place, or <c>null</c> if the time is not specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public DateTime? Time { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this task history event.
  /// </summary>
  /// <value>
  ///   A string containing the event identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the user who is attributed as the source of this event.
  /// </summary>
  /// <value>
  ///   An <see cref="OpenXmlTaskUserElement"/> representing the user responsible for the event,
  ///   or <c>null</c> if no attribution is specified.
  /// </value>
  public OpenXmlTaskUserElement? AttributionTaskUser { get; set; }

  /// <summary>
  ///   Gets or sets the anchor that links this event to a specific location in the document.
  /// </summary>
  /// <value>
  ///   A <see cref="TaskAnchor"/> object defining the document location,
  ///   or <c>null</c> if the event is not anchored to a specific location.
  /// </value>
  public TaskAnchor? TaskAnchor { get; set; }

  /// <summary>
  ///   Gets or sets the user to whom the task was assigned in this event.
  /// </summary>
  /// <value>
  ///   An <see cref="OpenXmlTaskUserElement"/> representing the assigned user,
  ///   or <c>null</c> if this event does not involve task assignment.
  /// </value>
  public OpenXmlTaskUserElement? AssignTaskUser { get; set; }

  /// <summary>
  ///   Gets or sets the user from whom the task was unassigned in this event.
  /// </summary>
  /// <value>
  ///   An <see cref="OpenXmlTaskUserElement"/> representing the unassigned user,
  ///   or <c>null</c> if this event does not involve task unassignment.
  /// </value>
  public OpenXmlTaskUserElement? UnassignTaskUser { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this event represents a task creation.
  /// </summary>
  /// <value>
  ///   <c>true</c> if this is a task creation event; <c>false</c> otherwise; or <c>null</c> if not applicable.
  /// </value>
  public bool? TaskCreateEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets the information about a task title change event.
  /// </summary>
  /// <value>
  ///   A <see cref="TaskTitleEventInfo"/> object containing title change details,
  ///   or <c>null</c> if this event does not involve a title change.
  /// </value>
  public TaskTitleEventInfo? TaskTitleEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets the information about a task schedule change event.
  /// </summary>
  /// <value>
  ///   A <see cref="TaskScheduleEventInfo"/> object containing schedule change details,
  ///   or <c>null</c> if this event does not involve a schedule change.
  /// </value>
  public TaskScheduleEventInfo? TaskScheduleEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets the information about a task progress change event.
  /// </summary>
  /// <value>
  ///   A <see cref="TaskProgressEventInfo"/> object containing progress change details,
  ///   or <c>null</c> if this event does not involve a progress change.
  /// </value>
  public TaskProgressEventInfo? TaskProgressEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets the information about a task priority change event.
  /// </summary>
  /// <value>
  ///   A <see cref="TaskPriorityEventInfo"/> object containing priority change details,
  ///   or <c>null</c> if this event does not involve a priority change.
  /// </value>
  public TaskPriorityEventInfo? TaskPriorityEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this event represents a task deletion.
  /// </summary>
  /// <value>
  ///   <c>true</c> if this is a task deletion event; <c>false</c> otherwise; or <c>null</c> if not applicable.
  /// </value>
  public bool? TaskDeleteEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this event represents a task undeletion (restoration).
  /// </summary>
  /// <value>
  ///   <c>true</c> if this is a task undeletion event; <c>false</c> otherwise; or <c>null</c> if not applicable.
  /// </value>
  public bool? TaskUndeleteEventInfo { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this event represents unassigning all users from the task.
  /// </summary>
  /// <value>
  ///   <c>true</c> if all users were unassigned; <c>false</c> otherwise; or <c>null</c> if not applicable.
  /// </value>
  public bool? TaskUnassignAll { get; set; }

  /// <summary>
  ///   Gets or sets the information about an undo operation performed on the task.
  /// </summary>
  /// <value>
  ///   A <see cref="TaskUndo"/> object containing undo operation details,
  ///   or <c>null</c> if this event does not involve an undo operation.
  /// </value>
  public TaskUndo? TaskUndo { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  public ExtensionList? ExtensionList { get; set; }
}