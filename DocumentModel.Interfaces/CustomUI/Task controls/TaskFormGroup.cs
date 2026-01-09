namespace DocumentModel;

/// <summary>
/// Represents a group of controls within a task form in the Office UI, supporting logical organization, dynamic state, and advanced callback integration for flexible task pane scenarios.
/// </summary>
/// <remarks>
/// This interface defines a logical grouping of controls displayed in a task pane or form. Task form groups organize related controls and provide options for labeling, visibility, sizing, and dynamic behavior through callback functions for advanced Office add-in or document solutions.
/// </remarks>
public interface TaskFormGroup : QualifiedElement, BuiltInControl, TaskFormGroupCategoryCollection
{
  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Label displayed for the task form group.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the task form group in the UI.
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