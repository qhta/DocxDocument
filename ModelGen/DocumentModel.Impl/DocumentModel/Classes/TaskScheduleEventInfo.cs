namespace DocumentModel;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public partial class TaskScheduleEventInfoImpl: ModelElementImpl, TaskScheduleEventInfo
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TaskScheduleEventInfoImpl(): base() {}
  
  public TaskScheduleEventInfoImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? StartDate
  {
    get => (System.DateTime?)OpenXmlElement?.StartDate?.Value;
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
    get => (System.DateTime?)OpenXmlElement?.DueDate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DueDate = (System.DateTime?)value;
    }
  }
  
}
