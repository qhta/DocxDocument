namespace DocumentModel;

/// <summary>
///   Represents a group of related tasks displayed in the backstage view or task pane.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a logical grouping of task categories
///   that organize commands and controls in the Office backstage view. Task groups provide structure,
///   labeling, visibility control, and sizing options for collections of related tasks.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface TaskGroup : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this task group.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this task group.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
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
  ///   This property is only available in Office 2010 and later.
  ///   The tag can be used to store application-specific information associated with this group.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office task group.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in group.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this task group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the task group relative to a built-in group.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this task group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the task group relative to a built-in group.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this task group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the task group relative to another custom group.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this task group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the task group relative to another custom group.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the task group.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's label.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the label is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the task group is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the group is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
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
  ///   This property is only available in Office 2010 and later.
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
  ///   This property is only available in Office 2010 and later.
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
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if label visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
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
  ///   This property is only available in Office 2010 and later.
  ///   This controls how the group can be resized within the backstage view or task pane.
  /// </remarks>
  public TaskSizesKind? AllowedTaskSizes { get; set; }

  /// <summary>
  ///   Gets or sets the collection of categories within this task group.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="TaskGroupCategory"/> objects, or <c>null</c> if no categories are defined.
  /// </value>
  public Collection<TaskGroupCategory>? TaskGroupCategories { get; set; }
}