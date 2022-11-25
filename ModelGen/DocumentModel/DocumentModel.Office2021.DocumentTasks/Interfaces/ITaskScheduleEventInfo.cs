namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public interface ITaskScheduleEventInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? StartDate { get ; set; }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? DueDate { get ; set; }
  
}
