namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TaskScheduleEventInfo Class.
/// </summary>
public class TaskScheduleEventInfo: ModelElement
{
  /// <summary>
  ///   startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? StartDate { get; set; }

  /// <summary>
  ///   dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DueDate { get; set; }
}