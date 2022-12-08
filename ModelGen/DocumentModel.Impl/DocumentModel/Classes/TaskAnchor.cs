namespace DocumentModel;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public class TaskAnchorImpl: ModelElementImpl, TaskAnchor
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public CommentAnchor? CommentAnchor
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
