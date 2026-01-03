namespace DocumentModel;

/// <summary>
///   Represents a collection of tasks within the document model.
/// </summary>
/// <remarks>
///   This interface provides access to a collection
///   of <see cref="Task"/> objects that define actionable items, assignments, and workflow
///   elements within the document. Tasks can be tracked, assigned to users, and monitored
///   through their lifecycle with associated history and progress information.
/// </remarks>
public interface Tasks : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of task items.
  /// </summary>
  public Collection<Task>? Items { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}