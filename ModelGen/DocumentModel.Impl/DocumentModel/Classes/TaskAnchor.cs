namespace DocumentModel;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public class TaskAnchorImpl: ModelElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>, TaskAnchor
{
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
