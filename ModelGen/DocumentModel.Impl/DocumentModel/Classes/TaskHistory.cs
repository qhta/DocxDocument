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
  
  public TaskHistoryImpl(): base() {}
  
  public TaskHistoryImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<TaskHistoryEvent>? TaskHistoryEvents
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
