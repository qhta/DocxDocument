namespace DocumentModel;

/// <summary>
/// Represents an undo operation for a task in Office UI, supporting identification and integration for advanced task management and event tracking scenarios.
/// </summary>
/// <remarks>
/// This interface defines a task undo element for Office UI, enabling unique identification and flexible linking of undo operations to task history events. It supports advanced workflows for undo functionality, auditing, and integration in Office add-ins or document solutions.
/// </remarks>
public interface TaskUndo
{
  /// <summary>
  /// Unique identifier for the task undo operation.
  /// </summary>
  public string? Id { get; set; }
}