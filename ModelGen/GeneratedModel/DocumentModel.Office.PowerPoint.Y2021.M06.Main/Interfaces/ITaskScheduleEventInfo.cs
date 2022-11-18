namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public interface ITaskScheduleEventInfo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// stDt, this property is only available in Microsoft365 and later.
  /// </summary>
  public DateTime? StDt { get ; set; }
  
  /// <summary>
  /// endDt, this property is only available in Microsoft365 and later.
  /// </summary>
  public DateTime? EndDt { get ; set; }
  
}
