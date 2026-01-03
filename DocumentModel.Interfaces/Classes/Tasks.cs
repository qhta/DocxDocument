namespace DocumentModel;

/// <summary>
///   Represents a collection of tasks within the document model.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and provides access to a collection
///   of <see cref="Task"/> objects that define actionable items, assignments, and workflow
///   elements within the document. Tasks can be tracked, assigned to users, and monitored
///   through their lifecycle with associated history and progress information.
/// </remarks>
public interface Tasks : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of task items.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="Task"/> objects, or <c>null</c> if no tasks are defined.
  /// </value>
  public Collection<Task>? Items { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  public ExtensionList? ExtensionList { get; set; }
}