namespace DocumentModel;

/// <summary>
/// Represents a group of related tasks displayed in the Office backstage view or task pane, supporting logical organization, dynamic state, and advanced callback integration for flexible task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines a logical grouping of task categories for organizing commands and controls in the Office backstage view or task pane. Task groups provide structure, labeling, visibility control, sizing options, and support dynamic behavior through callback functions for advanced Office add-in or document solutions.
/// </remarks>
public interface TaskGroup : CustomUIControl, BuiltInObject, TaggedObject, 
  VisibleControl, LabelledControl, ShowLabelControl, HelperControl,
  TaskFormGroupCategoryCollection
{
  
  /// <summary>
  /// Allowed task sizes for this group.
  /// </summary>
  public TaskSizesKind? AllowedTaskSizes { get; set; }
}