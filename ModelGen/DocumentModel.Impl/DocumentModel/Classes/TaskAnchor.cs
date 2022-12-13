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
  
  public TaskAnchorImpl(): base() {}
  
  public TaskAnchorImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.CommentAnchor? CommentAnchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
