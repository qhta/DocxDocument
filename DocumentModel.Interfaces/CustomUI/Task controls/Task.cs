namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a task element for Office UI, supporting identification, anchoring, history tracking, and extensibility for advanced task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines a task for Office UI, enabling unique identification, association with anchors, history tracking, and extensibility through extension lists. It supports advanced workflows for task management, annotation, and integration in Office add-ins or document solutions.
/// </remarks>
public interface Task : IdentifiedElement, CollectionItem, ExtendableElement
{

  /// <summary>
  /// Anchor associated with the task.
  /// </summary>
  public TaskAnchor? TaskAnchor { get; set; }

  /// <summary>
  /// History tracking for the task.
  /// </summary>
  public TaskHistory? TaskHistory { get; set; }

}