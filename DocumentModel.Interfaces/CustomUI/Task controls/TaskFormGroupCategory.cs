namespace DocumentModel;

/// <summary>
/// Represents a category within a task form group that organizes related tasks, supporting logical structure, dynamic state, and advanced callback integration for Office UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a logical category for grouping related tasks within a <c>TaskFormGroup</c>. Categories provide organizational structure, labeling, positioning control, and support dynamic behavior through callback functions for advanced Office add-in or document solutions.
/// </remarks>
public interface TaskFormGroupCategory : CustomUIControl, BuiltInObject, TaggedObject, 
  VisibleControl, LabelledControl,
  TaskFormGroupCollection
{

}