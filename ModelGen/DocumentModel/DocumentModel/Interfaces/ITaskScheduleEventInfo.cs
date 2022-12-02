namespace DocumentModel;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public interface ITaskScheduleEventInfo // : DocumentModel.ITypedOpenXmlLeafElement
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
