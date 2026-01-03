namespace DocumentModel;

/// <summary>
///   Represents a group of controls within a task form in the Office UI.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a logical grouping of controls
///   displayed in a task pane or form. Task form groups organize related controls and provide
///   options for labeling, visibility, and sizing.
/// </remarks>
public interface TaskFormGroup : IElementCollection<TaskFormGroupCategory>
{
  /// <summary>
  ///   Gets or sets the unique identifier for this task form group.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this task form group.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if not specified.
  /// </value>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <value>
  ///   A string containing custom tag data, or <c>null</c> if no tag is specified.
  /// </value>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this group.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office task form group.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in group.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the task form group.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's label.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the label is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the task form group is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the group is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the group should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the helper text that provides additional information about the group.
  /// </summary>
  /// <value>
  ///   A string containing the helper text, or <c>null</c> if no helper text is specified.
  /// </value>
  /// <remarks>
  ///   Helper text is typically displayed as a tooltip or supplementary information.
  /// </remarks>
  public string? HelperText { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's helper text.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if helper text is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the helper text.
  /// </remarks>
  public string? GetHelperText { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the group's label should be displayed.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the label is shown; <c>false</c> if hidden; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if label visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the label should be displayed.
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the allowed task sizes for this group.
  /// </summary>
  /// <value>
  ///   A <see cref="TaskSizesKind"/> value specifying which task sizes are permitted, or <c>null</c> to allow all sizes.
  /// </value>
  /// <remarks>
  ///   This controls how the group can be resized within the task pane.
  /// </remarks>
  public TaskSizesKind? AllowedTaskSizes { get; set; }

}