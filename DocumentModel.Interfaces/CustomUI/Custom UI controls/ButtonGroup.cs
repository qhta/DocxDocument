namespace DocumentModel;

/// <summary>
///   Represents a group of buttons and controls within a ribbon group or menu.
/// </summary>
/// <remarks>
///   This interface defines a container that groups
///   related buttons and controls together within the Office ribbon UI. Button groups allow
///   multiple controls to be visually clustered, providing better organization and efficient
///   use of ribbon space by displaying controls in a compact arrangement.
/// </remarks>
public interface ButtonGroup : BoxContentControl
{
  /// <summary>
  ///   Gets or sets the unique identifier for this button group.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this button group.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this button group.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the button group is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button group's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the button group should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this button group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the button group relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this button group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the button group relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this button group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the button group relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this button group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the button group relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a cloned instance of a built-in or custom control.
  /// </summary>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  ///   Gets or sets a regular button control within the button group.
  /// </summary>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a toggle button control that maintains an on/off state.
  /// </summary>
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a gallery control that displays a collection of selectable items.
  /// </summary>
  public GalleryRegular? GalleryRegular { get; set; }

  /// <summary>
  ///   Gets or sets a menu control that displays a dropdown list of options.
  /// </summary>
  public MenuRegular? MenuRegular { get; set; }

  /// <summary>
  ///   Gets or sets a dynamic menu control that generates menu items at runtime.
  /// </summary>
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }

  /// <summary>
  ///   Gets or sets a split button control that combines a default action with a dropdown menu.
  /// </summary>
  public SplitButtonRegular? SplitButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a separator that provides visual division between controls.
  /// </summary>
  public Separator? Separator { get; set; }
}