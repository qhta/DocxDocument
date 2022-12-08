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
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public TaskAnchor? TaskAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public TaskHistory? TaskHistory
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
