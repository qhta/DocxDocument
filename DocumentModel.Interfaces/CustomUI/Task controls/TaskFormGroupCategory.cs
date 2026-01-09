namespace DocumentModel;

/// <summary>
/// Represents a category within a task form group that organizes related tasks, supporting logical structure, dynamic state, and advanced callback integration for Office UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a logical category for grouping related tasks within a <c>TaskFormGroup</c>. Categories provide organizational structure, labeling, positioning control, and support dynamic behavior through callback functions for advanced Office add-in or document solutions.
/// </remarks>
public interface TaskFormGroupCategory : CustomUIControl, BuiltInControl, TaskFormGroupCollection
{

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Show the task form group category in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Label displayed for the task form group category.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

}