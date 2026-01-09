namespace DocumentModel;

/// <summary>
/// Represents a group of related tasks displayed in the Office backstage view or task pane, supporting logical organization, dynamic state, and advanced callback integration for flexible task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines a logical grouping of task categories for organizing commands and controls in the Office backstage view or task pane. Task groups provide structure, labeling, visibility control, sizing options, and support dynamic behavior through callback functions for advanced Office add-in or document solutions.
/// </remarks>
public interface TaskGroup : CustomUIControl, BuiltInControl, TaskGroupCategoryCollection
{
  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Label displayed for the task group.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the task group in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Helper text providing additional information about the group.
  /// </summary>
  public string? HelperText { get; set; }

  /// <summary>
  /// Callback for dynamic helper text.
  /// </summary>
  public string? GetHelperText { get; set; }

  /// <summary>
  /// Show the group label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Allowed task sizes for this group.
  /// </summary>
  public TaskSizesKind? AllowedTaskSizes { get; set; }

}