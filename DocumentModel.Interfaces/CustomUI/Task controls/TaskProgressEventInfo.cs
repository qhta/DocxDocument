namespace DocumentModel.CustomUI;

/// <summary>
/// Represents information about a task progress change event in Office UI, supporting tracking of completion percentage for advanced task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines the structure for capturing progress changes in task history events, enabling tracking of percent complete, auditing, and integration in Office add-ins or document solutions.
/// </remarks>
public interface TaskProgressEventInfo
{
  /// <summary>
  /// Completion percentage associated with the task progress change event.
  /// </summary>
  public Int32? PercentComplete { get; set; }
}