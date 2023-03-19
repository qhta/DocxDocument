namespace DocumentModel;

/// <summary>
///   Defines the TaskAnchor Class.
/// </summary>
public class TaskAnchor: ModelElement
{
  /// <summary>
  ///   CommentAnchor.
  /// </summary>
  public CommentAnchor? CommentAnchor { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}