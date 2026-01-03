namespace DocumentModel;

/// <summary>
///   Represents a group container within a ribbon tab that organizes related controls.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a logical grouping of controls
///   within a ribbon tab. Groups are the primary organizational unit in the ribbon interface,
///   containing collections of related commands, buttons, galleries, and other controls.
///   Groups support visual customization with labels, images, tooltips, and can include a dialog box launcher
///   for accessing additional functionality. They provide automatic scaling behavior to optimize
///   ribbon space usage when the window is resized.
/// </remarks>
public interface Group : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this group.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this group.
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
  ///   Gets or sets the identifier for a built-in Microsoft Office group.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in group.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the group.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  ///   The label is displayed at the bottom of the group in the ribbon.
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
  ///   Gets or sets the custom image identifier for the group icon.
  /// </summary>
  /// <value>
  ///   A string containing the image identifier, or <c>null</c> if no custom image is specified.
  /// </value>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  ///   Group images are displayed when the group is collapsed due to ribbon sizing.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the group icon.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office image identifier, or <c>null</c> if not using a built-in image.
  /// </value>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the group.
  ///   Group images are displayed when the group is collapsed due to ribbon sizing.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's image.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the image is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the group relative to a built-in group.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the group relative to a built-in group.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the group relative to another custom group.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this group should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the group relative to another custom group.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the group.
  /// </summary>
  /// <value>
  ///   A string containing the screentip text, or <c>null</c> if no screentip is specified.
  /// </value>
  /// <remarks>
  ///   The screentip is displayed when the user hovers over the collapsed group button.
  /// </remarks>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's screentip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the screentip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the group.
  /// </summary>
  /// <value>
  ///   A string containing the supertip text, or <c>null</c> if no supertip is specified.
  /// </value>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips and are displayed when hovering over the collapsed group button.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's supertip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the supertip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the group is visible.
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
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the group.
  /// </summary>
  /// <value>
  ///   A string containing the keytip character(s), or <c>null</c> if no keytip is specified.
  /// </value>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's keytip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the keytip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the group automatically scales its controls when ribbon space is limited.
  /// </summary>
  /// <value>
  ///   <c>true</c> to enable automatic scaling; <c>false</c> to disable it; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  ///   When enabled, the group will progressively reduce control sizes and eventually collapse to a single button
  ///   with a dropdown menu as the ribbon width decreases.
  /// </remarks>
  public bool? AutoScale { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether controls in the group should be vertically centered.
  /// </summary>
  /// <value>
  ///   <c>true</c> to center controls vertically; <c>false</c> otherwise; or <c>null</c> to use the default alignment.
  /// </value>
  /// <remarks>
  ///   This affects how controls of different sizes are aligned within the group.
  /// </remarks>
  public bool? CenterVertically { get; set; }

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
  ///   An <see cref="CheckBox"/> object, or <c>null</c> if no checkbox is defined.
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
  ///   Gets or sets a box container for organizing and layouting child controls.
  /// </summary>
  /// <value>
  ///   A <see cref="Box"/> object, or <c>null</c> if no box is defined.
  /// </value>
  public Box? Box { get; set; }

  /// <summary>
  ///   Gets or sets a button group that clusters multiple buttons together.
  /// </summary>
  /// <value>
  ///   A <see cref="ButtonGroup"/> object, or <c>null</c> if no button group is defined.
  /// </value>
  public ButtonGroup? ButtonGroup { get; set; }

  /// <summary>
  ///   Gets or sets a separator that provides visual division between controls.
  /// </summary>
  /// <value>
  ///   A <see cref="Separator"/> object, or <c>null</c> if no separator is defined.
  /// </value>
  public Separator? Separator { get; set; }

  /// <summary>
  ///   Gets or sets a dialog box launcher that opens additional options or settings.
  /// </summary>
  /// <value>
  ///   A <see cref="DialogBoxLauncher"/> object, or <c>null</c> if no dialog box launcher is defined.
  /// </value>
  /// <remarks>
  ///   The dialog box launcher appears as a small icon in the bottom-right corner of the group,
  ///   providing access to a dialog or task pane with more comprehensive options.
  /// </remarks>
  public DialogBoxLauncher? DialogBoxLauncher { get; set; }
}