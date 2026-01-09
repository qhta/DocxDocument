namespace DocumentModel;

/// <summary>
/// Represents information about a task priority change event in Office UI, supporting tracking of priority values for advanced task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines the structure for capturing priority changes in task history events, enabling tracking of priority values, auditing, and integration in Office add-ins or document solutions.
/// </remarks>
public interface TaskPriorityEventInfo
{
  /// <summary>
  /// Priority value associated with the task priority change event.
  /// </summary>
  public Int32? Value { get; set; }
}