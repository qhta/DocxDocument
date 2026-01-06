namespace DocumentModel;

/// <summary>
///   Represents a category within a task form group that organizes related tasks.
/// </summary>
/// <remarks>
///   This interface defines a logical category
///   that groups related tasks within a <see cref="TaskFormGroup"/>. Categories provide
///   organizational structure, labeling, and positioning control for task collections.
/// </remarks>
public interface TaskFormGroupCategory : ElementCollection<TaskFormGroupTask>
{
  /// <summary>
  ///   Gets or sets the unique identifier for this task form group category.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this task form group category.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this category.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office task form group category.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this category should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the category relative to a built-in category.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this category should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the category relative to a built-in category.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this category should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the category relative to another custom category.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this category should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the category relative to another custom category.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the task form group category is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the category's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the category should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the task form group category.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the category's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

}