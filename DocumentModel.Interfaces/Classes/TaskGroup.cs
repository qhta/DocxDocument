namespace DocumentModel;

/// <summary>
///   Represents a group of related tasks displayed in the backstage view or task pane.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a logical grouping of task categories
///   that organize commands and controls in the Office backstage view. Task groups provide structure,
///   labeling, visibility control, and sizing options for collections of related tasks.
/// </remarks>
public interface TaskGroup : IElementCollection<TaskGroupCategory>
{
  /// <summary>
  ///   Gets or sets the unique identifier for this task group.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this task group.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this group.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office task group.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this task group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the task group relative to a built-in group.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this task group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the task group relative to a built-in group.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this task group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the task group relative to another custom group.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this task group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the task group relative to another custom group.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the task group.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the task group is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the group should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the helper text that provides additional information about the group.
  /// </summary>
  /// <remarks>
  ///   Helper text is typically displayed as a tooltip or supplementary information.
  /// </remarks>
  public string? HelperText { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's helper text.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the helper text.
  /// </remarks>
  public string? GetHelperText { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the group's label should be displayed.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the label should be displayed.
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the allowed task sizes for this group.
  /// </summary>
  /// <remarks>
  ///   This controls how the group can be resized within the backstage view or task pane.
  /// </remarks>
  public TaskSizesKind? AllowedTaskSizes { get; set; }

}