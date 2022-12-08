namespace DocumentModel;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public class TaskHistoryImpl: ModelElementImpl, TaskHistory
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<TaskHistoryEvent>? TaskHistoryEvents
  {
    get;
    set;
  }
  
}
