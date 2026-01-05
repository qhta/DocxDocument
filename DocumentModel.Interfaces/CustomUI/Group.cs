namespace DocumentModel;

/// <summary>
///   Represents a group container within a ribbon tab that organizes related controls.
/// </summary>
/// <remarks>
///   This interface defines a logical grouping of controls
///   within a ribbon tab. Groups are the primary organizational unit in the ribbon interface,
///   containing collections of related commands, buttons, galleries, and other controls.
///   Groups support visual customization with labels, images, tooltips, and can include a dialog box launcher
///   for accessing additional functionality. They provide automatic scaling behavior to optimize
///   ribbon space usage when the window is resized.
/// </remarks>
public interface Group :
{
  /// <summary>
  ///   Gets or sets the unique identifier for this group.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this group.
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
  ///   Gets or sets the identifier for a built-in Microsoft Office group.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the group.
  /// </summary>
  /// <remarks>
  ///   The label is displayed at the bottom of the group in the ribbon.
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the group icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  ///   Group images are displayed when the group is collapsed due to ribbon sizing.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the group icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the group.
  ///   Group images are displayed when the group is collapsed due to ribbon sizing.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the group relative to a built-in group.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the group relative to a built-in group.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the group relative to another custom group.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this group should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the group relative to another custom group.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the group.
  /// </summary>
  /// <remarks>
  ///   The screentip is displayed when the user hovers over the collapsed group button.
  /// </remarks>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the group.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips and are displayed when hovering over the collapsed group button.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the group is visible.
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
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the group.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the group's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the group automatically scales its controls when ribbon space is limited.
  /// </summary>
  /// <remarks>
  ///   When enabled, the group will progressively reduce control sizes and eventually collapse to a single button
  ///   with a dropdown menu as the ribbon width decreases.
  /// </remarks>
  public bool? AutoScale { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether controls in the group should be vertically centered.
  /// </summary>
  /// <remarks>
  ///   This affects how controls of different sizes are aligned within the group.
  /// </remarks>
  public bool? CenterVertically { get; set; }

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
  ///   Gets or sets a box container for organizing and layouting child controls.
  /// </summary>
  public Box? Box { get; set; }

  /// <summary>
  ///   Gets or sets a button group that clusters multiple buttons together.
  /// </summary>
  public ButtonGroup? ButtonGroup { get; set; }

  /// <summary>
  ///   Gets or sets a separator that provides visual division between controls.
  /// </summary>
  public Separator? Separator { get; set; }

  /// <summary>
  ///   Gets or sets a dialog box launcher that opens additional options or settings.
  /// </summary>
  /// <remarks>
  ///   The dialog box launcher appears as a small icon in the bottom-right corner of the group,
  ///   providing access to a dialog or task pane with more comprehensive options.
  /// </remarks>
  public DialogBoxLauncher? DialogBoxLauncher { get; set; }
}