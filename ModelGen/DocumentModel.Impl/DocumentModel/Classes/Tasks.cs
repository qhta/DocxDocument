namespace DocumentModel;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public class TasksImpl: ModelElementImpl, Tasks
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TasksImpl(): base() {}
  
  public TasksImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Task>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
