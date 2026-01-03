namespace DocumentModel;

/// <summary>
///   Represents a container control that organizes and layouts child controls within the ribbon interface.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a flexible container that can hold
///   various types of controls including buttons, checkboxes, galleries, menus, and nested boxes.
///   Boxes provide layout capabilities with customizable styling to organize controls in a structured manner.
///   They support both horizontal and vertical arrangements depending on the specified box style.
/// </remarks>
public interface Box : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this box container.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this box container.
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
  ///   The tag can be used to store application-specific information associated with this box.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the box is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the box is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the box's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the box should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this box should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the box relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this box should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the box relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this box should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the box relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this box should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the box relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the visual style that determines the layout behavior of the box.
  /// </summary>
  /// <value>
  ///   A <see cref="BoxStyleKind"/> value specifying the layout style, or <c>null</c> to use the default style.
  /// </value>
  /// <remarks>
  ///   The box style controls whether child controls are arranged horizontally or vertically.
  /// </remarks>
  public BoxStyleKind? BoxStyle { get; set; }

  /// <summary>
  ///   Gets or sets a cloned instance of a built-in or custom control.
  /// </summary>
  /// <value>
  ///   A <see cref="ControlClone"/> object, or <c>null</c> if no control clone is defined.
  /// </value>
  public ControlClone? ControlClone { get; set; }

  /// <summary>
  ///   Gets or sets a label control for displaying static text.
  /// </summary>
  /// <value>
  ///   A <see cref="LabelControl"/> object, or <c>null</c> if no label is defined.
  /// </value>
  public LabelControl? LabelControl { get; set; }

  /// <summary>
  ///   Gets or sets a button control for executing actions.
  /// </summary>
  /// <value>
  ///   A <see cref="Button"/> object, or <c>null</c> if no button is defined.
  /// </value>
  public Button? Button { get; set; }

  /// <summary>
  ///   Gets or sets a toggle button control that maintains an on/off state.
  /// </summary>
  /// <value>
  ///   A <see cref="ToggleButton"/> object, or <c>null</c> if no toggle button is defined.
  /// </value>
  public ToggleButton? ToggleButton { get; set; }

  /// <summary>
  ///   Gets or sets a checkbox control for boolean selection.
  /// </summary>
  /// <value>
  ///   A <see cref="CheckBox"/> object, or <c>null</c> if no checkbox is defined.
  /// </value>
  public CheckBox? CheckBox { get; set; }

  /// <summary>
  ///   Gets or sets an edit box control for text input.
  /// </summary>
  /// <value>
  ///   An <see cref="EditBox"/> object, or <c>null</c> if no edit box is defined.
  /// </value>
  public EditBox? EditBox { get; set; }

  /// <summary>
  ///   Gets or sets a combo box control that combines text input with a dropdown list.
  /// </summary>
  /// <value>
  ///   A <see cref="ComboBox"/> object, or <c>null</c> if no combo box is defined.
  /// </value>
  public ComboBox? ComboBox { get; set; }

  /// <summary>
  ///   Gets or sets a dropdown control for selecting from a list of options.
  /// </summary>
  /// <value>
  ///   A <see cref="DropDownRegular"/> object, or <c>null</c> if no dropdown is defined.
  /// </value>
  public DropDownRegular? DropDownRegular { get; set; }

  /// <summary>
  ///   Gets or sets a gallery control that displays a collection of selectable items.
  /// </summary>
  /// <value>
  ///   A <see cref="Gallery"/> object, or <c>null</c> if no gallery is defined.
  /// </value>
  public Gallery? Gallery { get; set; }

  /// <summary>
  ///   Gets or sets a menu control that displays a dropdown list of commands.
  /// </summary>
  /// <value>
  ///   A <see cref="Menu"/> object, or <c>null</c> if no menu is defined.
  /// </value>
  public Menu? Menu { get; set; }

  /// <summary>
  ///   Gets or sets a dynamic menu control that generates menu items at runtime.
  /// </summary>
  /// <value>
  ///   A <see cref="DynamicMenu"/> object, or <c>null</c> if no dynamic menu is defined.
  /// </value>
  public DynamicMenu? DynamicMenu { get; set; }

  /// <summary>
  ///   Gets or sets a split button control that combines a default action with a dropdown menu.
  /// </summary>
  /// <value>
  ///   A <see cref="SplitButton"/> object, or <c>null</c> if no split button is defined.
  /// </value>
  public SplitButton? SplitButton { get; set; }

  /// <summary>
  ///   Gets or sets a nested box container for hierarchical control organization.
  /// </summary>
  /// <value>
  ///   A <see cref="Box"/> object, or <c>null</c> if no child box is defined.
  /// </value>
  public Box? ChildBox { get; set; }

  /// <summary>
  ///   Gets or sets a button group that clusters multiple buttons together.
  /// </summary>
  /// <value>
  ///   A <see cref="ButtonGroup"/> object, or <c>null</c> if no button group is defined.
  /// </value>
  public ButtonGroup? ButtonGroup { get; set; }
}