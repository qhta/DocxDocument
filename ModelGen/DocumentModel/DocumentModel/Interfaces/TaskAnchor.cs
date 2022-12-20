namespace DocumentModel;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public partial interface TaskAnchor
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.CommentAnchor? CommentAnchor { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.ExtensionList? ExtensionList { get; set; }
  
}
