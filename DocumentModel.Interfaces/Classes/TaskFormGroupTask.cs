namespace DocumentModel;

/// <summary>
///   Represents an individual task within a task form group category.
/// </summary>
/// <remarks>
///   This interface defines a single actionable task
///   within a <see cref="TaskFormGroupCategory"/>. Tasks provide interactive elements with
///   customizable appearance, behavior, and positioning within the task pane UI.
/// </remarks>
public interface TaskFormGroupTask : CollectionItem, ElementCollection<BackstageGroup>
{
  /// <summary>
  ///   Gets or sets the unique identifier for this task.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this task.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this task.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office task.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this task should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the task relative to a built-in task.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this task should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the task relative to a built-in task.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this task should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the task relative to another custom task.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this task should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the task relative to another custom task.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the task icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the task icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the task.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the task's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the task is enabled and can be interacted with.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the task is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the task should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the task.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the task's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the task is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the task's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the task should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the description text that provides additional information about the task.
  /// </summary>
  /// <remarks>
  ///   The description is typically displayed as a tooltip or in supplementary UI elements.
  /// </remarks>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the task's description.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the task.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the task's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

}