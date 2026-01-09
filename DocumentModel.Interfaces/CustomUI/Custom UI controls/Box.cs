namespace DocumentModel;

/// <summary>
///   Represents a container control that organizes and layouts child controls within the ribbon interface.
/// </summary>
/// <remarks>
///   This interface defines a flexible container that can hold
///   various types of controls including buttons, checkboxes, galleries, menus, and nested boxes.
///   Boxes provide layout capabilities with customizable styling to organize controls in a structured manner.
///   They support both horizontal and vertical arrangements depending on the specified box style.
/// </remarks>
public interface Box
{
  /// <summary>
  ///   Gets or sets the unique identifier for this box container.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this box container.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this box.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the box is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the box's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the box should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the box relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the box relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the box relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the box relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the visual style that determines the layout behavior of the box.
  /// </summary>
  /// <remarks>
  ///   The box style controls whether child controls are arranged horizontally or vertically.
  /// </remarks>
  public BoxStyleKind? BoxStyle { get; set; }

  /// <summary>
  ///   Gets or sets a cloned instance of a built-in or custom control.
  /// </summary>
  public ControlClone? ControlClone { get; set; }

  /// <summary>
  ///   Gets or sets a label control for displaying static text.
  /// </summary>
  public LabelControl? LabelControl { get; set; }

  /// <summary>
  ///   Gets or sets a button control for executing actions.
  /// </summary>
  public Button? Button { get; set; }

  /// <summary>
  ///   Gets or sets a toggle button control that maintains an on/off state.
  /// </summary>
  public ToggleButton? ToggleButton { get; set; }

  /// <summary>
  ///   Gets or sets a checkbox control for boolean selection.
  /// </summary>
  public CheckBox? CheckBox { get; set; }

  /// <summary>
  ///   Gets or sets an edit box control for text input.
  /// </summary>
  public EditBox? EditBox { get; set; }

  /// <summary>
  ///   Gets or sets a combo box control that combines text input with a dropdown list.
  /// </summary>
  public ComboBox? ComboBox { get; set; }

  /// <summary>
  ///   Gets or sets a dropdown control for selecting from a list of options.
  /// </summary>
  public DropDownRegular? DropDownRegular { get; set; }

  /// <summary>
  ///   Gets or sets a gallery control that displays a collection of selectable items.
  /// </summary>
  public Gallery? Gallery { get; set; }

  /// <summary>
  ///   Gets or sets a menu control that displays a dropdown list of commands.
  /// </summary>
  public Menu? Menu { get; set; }

  /// <summary>
  ///   Gets or sets a dynamic menu control that generates menu items at runtime.
  /// </summary>
  public DynamicMenu? DynamicMenu { get; set; }

  /// <summary>
  ///   Gets or sets a split button control that combines a default action with a dropdown menu.
  /// </summary>
  public SplitButton? SplitButton { get; set; }

  /// <summary>
  ///   Gets or sets a nested box container for hierarchical control organization.
  /// </summary>
  public Box? ChildBox { get; set; }

  /// <summary>
  ///   Gets or sets a button group that clusters multiple buttons together.
  /// </summary>
  public ButtonGroup? ButtonGroup { get; set; }
}