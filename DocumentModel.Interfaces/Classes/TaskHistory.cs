namespace DocumentModel;

/// <summary>
///   Represents a collection of historical events related to task execution and state changes.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and provides access to a chronological
///   collection of <see cref="TaskHistoryEvent"/> objects that track the lifecycle and modifications
///   of tasks within the document model. This enables audit trails, undo/redo functionality,
///   and historical analysis of task-related operations.
/// </remarks>
public interface TaskHistory : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of historical events that have occurred for tasks.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="TaskHistoryEvent"/> objects representing the chronological history,
  ///   or <c>null</c> if no history events are recorded.
  /// </value>
  public Collection<TaskHistoryEvent>? TaskHistoryEvents { get; set; }
}