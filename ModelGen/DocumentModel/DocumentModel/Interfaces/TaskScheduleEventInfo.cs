namespace DocumentModel;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public partial interface TaskScheduleEventInfo
{
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? StartDate { get; set; }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DueDate { get; set; }
  
}
