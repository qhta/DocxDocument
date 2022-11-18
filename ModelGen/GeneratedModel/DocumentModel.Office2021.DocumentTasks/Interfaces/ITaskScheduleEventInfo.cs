namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public interface ITaskScheduleEventInfo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? StartDate { get ; set; }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DueDate { get ; set; }
  
}
