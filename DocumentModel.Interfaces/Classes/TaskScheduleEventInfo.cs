namespace DocumentModel;

/// <summary>
///   Defines the TaskScheduleEventInfo Class.
/// </summary>
public interface TaskScheduleEventInfo:
{
  /// <summary>
  ///   startDate
  /// </summary>
  public DateTime? StartDate { get; set; }
  /// <summary>
  ///   dueDate
  /// </summary>
  public DateTime? DueDate { get; set; }
}