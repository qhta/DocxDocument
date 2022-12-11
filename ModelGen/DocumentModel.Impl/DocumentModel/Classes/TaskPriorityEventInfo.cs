namespace DocumentModel;

/// <summary>
/// Defines the TaskPriorityEventInfo Class.
/// </summary>
public class TaskPriorityEventInfoImpl: ModelElementImpl, TaskPriorityEventInfo
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TaskPriorityEventInfoImpl(): base() {}
  
  public TaskPriorityEventInfoImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? Value
  {
    get => (Int32?)OpenXmlElement?.Value?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Value = (System.Int32?)value;
    }
  }
  
}
