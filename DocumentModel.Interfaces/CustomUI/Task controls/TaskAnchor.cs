namespace DocumentModel.CustomUI;

/// <summary>
/// Represents an anchor point for task-related elements in Office UI, supporting extensibility and integration with comment anchors for advanced task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines a task anchor for Office UI, enabling association with comment anchors and extensible elements. It supports flexible linking of tasks to document locations, comments, or other extensible elements, facilitating advanced workflows and integration in Office add-ins or document solutions.
/// </remarks>
public interface TaskAnchor : ExtendableElement
{
  /// <summary>
  /// Comment anchor associated with the task anchor.
  /// </summary>
  public CommentAnchor? CommentAnchor { get; set; }
}