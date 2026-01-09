namespace DocumentModel;

/// <summary>
/// Represents information about a task title change event in Office UI, supporting advanced task management and event tracking scenarios.
/// </summary>
/// <remarks>
/// This interface defines the structure for capturing title changes in task history events, enabling tracking of modifications, auditing, and integration in Office add-ins or document solutions.
/// </remarks>
public interface TaskTitleEventInfo
{
  /// <summary>
  /// Title value associated with the task title change event.
  /// </summary>
  public string? Title { get; set; }
}