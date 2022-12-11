namespace DocumentModel;

/// <summary>
/// Defines the Task Class.
/// </summary>
public class TaskImpl: ModelElementImpl, Task
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.Task?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TaskImpl(): base() {}
  
  public TaskImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public TaskAnchor? TaskAnchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public TaskHistory? TaskHistory
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
