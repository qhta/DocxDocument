namespace DocumentModel.CustomUI;

/// <summary>
///   Represents a collection of historical events related to task execution and state changes.
/// </summary>
/// <remarks>
///   This interface provides access to a chronological
///   collection of <see cref="TaskHistoryEvent"/> objects that track the lifecycle and modifications
///   of tasks within the document model. This enables audit trails, undo/redo functionality,
///   and historical analysis of task-related operations.
/// </remarks>
public interface TaskHistory: ElementCollection<TaskHistoryEvent>
{

}