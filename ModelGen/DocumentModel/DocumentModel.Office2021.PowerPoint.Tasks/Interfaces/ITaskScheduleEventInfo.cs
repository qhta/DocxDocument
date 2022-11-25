namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public interface ITaskScheduleEventInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// stDt, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? StDt { get ; set; }
  
  /// <summary>
  /// endDt, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? EndDt { get ; set; }
  
}
