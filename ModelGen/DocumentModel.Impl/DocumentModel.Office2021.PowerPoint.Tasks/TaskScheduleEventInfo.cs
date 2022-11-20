namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public class TaskScheduleEventInfo: ITaskScheduleEventInfo
{
  /// <summary>
  /// stDt, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? StDt
  {
    get;
    set;
  }
  
  /// <summary>
  /// endDt, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? EndDt
  {
    get;
    set;
  }
  
}
