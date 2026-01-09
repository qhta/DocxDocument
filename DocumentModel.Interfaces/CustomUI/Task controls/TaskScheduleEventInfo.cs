namespace DocumentModel;

/// <summary>
/// Represents information about a task schedule change event in Office UI, supporting tracking of start and due dates for advanced task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines the structure for capturing schedule changes in task history events, enabling tracking of start and due dates, auditing, and integration in Office add-ins or document solutions.
/// </remarks>
public interface TaskScheduleEventInfo
{
  /// <summary>
  /// Start date associated with the task schedule change event.
  /// </summary>
  public DateTime? StartDate { get; set; }

  /// <summary>
  /// Due date associated with the task schedule change event.
  /// </summary>
  public DateTime? DueDate { get; set; }
}