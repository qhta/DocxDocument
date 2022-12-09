namespace DocumentModel;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public class TaskScheduleEventInfoImpl: ModelElementImpl, TaskScheduleEventInfo
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? StartDate
  {
    get => (DateTime?)OpenXmlElement?.StartDate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartDate = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DueDate
  {
    get => (DateTime?)OpenXmlElement?.DueDate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DueDate = (System.DateTime?)value;
    }
  }
  
}
