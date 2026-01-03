namespace DocumentModel;

/// <summary>
///   Represents a category within a task group that organizes related tasks.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a logical category
///   that groups related tasks within a <see cref="TaskGroup"/>. Categories provide
///   organizational structure, labeling, and positioning control for task collections
///   in the backstage view or task pane.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface TaskGroupCategory : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this task group category.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this task group category.
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
  ///   The tag can be used to store application-specific information associated with this category.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office task group category.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in category.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this category should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the category relative to a built-in category.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this category should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the category relative to a built-in category.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this category should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the category relative to another custom category.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this category should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to position the category relative to another custom category.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the task group category is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the category is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the category's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a boolean value indicating whether the category should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the task group category.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the category's label.
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
  ///   Gets or sets the collection of tasks within this category.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="TaskGroupTask"/> objects, or <c>null</c> if no tasks are defined.
  /// </value>
  public Collection<TaskGroupTask>? TaskGroupTasks { get; set; }
}