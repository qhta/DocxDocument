namespace DocumentModel;

/// <summary>
/// Represents a group container within a ribbon tab that organizes related controls, supporting visual customization, automatic scaling, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a logical grouping of controls within a ribbon tab. Groups are the primary organizational unit in the ribbon interface, containing collections of related commands, buttons, galleries, and other controls. Groups support visual customization with labels, images, tooltips, and can include a dialog box launcher for accessing additional functionality. They provide automatic scaling behavior to optimize ribbon space usage when the window is resized.
/// </remarks>
public interface Group : CustomUIControl, BuiltInControl
{
  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Label displayed at the bottom of the group in the ribbon.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Custom image identifier for the group icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the group icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic group image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Screentip text for the group, shown when hovering over the collapsed group button.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the group, shown as extended tooltip.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Show the group in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the group.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Enable automatic scaling of controls when ribbon space is limited.
  /// </summary>
  public bool? AutoScale { get; set; }

  /// <summary>
  /// Vertically center controls in the group.
  /// </summary>
  public bool? CenterVertically { get; set; }

  /// <summary>
  /// Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlClone? ControlClone { get; set; }

  /// <summary>
  /// Label control for displaying static text.
  /// </summary>
  public LabelControl? LabelControl { get; set; }

  /// <summary>
  /// Button control for executing actions.
  /// </summary>
  public Button? Button { get; set; }

  /// <summary>
  /// Toggle button control that maintains an on/off state.
  /// </summary>
  public ToggleButton? ToggleButton { get; set; }

  /// <summary>
  /// Checkbox control for boolean selection.
  /// </summary>
  public CheckBox? CheckBox { get; set; }

  /// <summary>
  /// Edit box control for text input.
  /// </summary>
  public EditBox? EditBox { get; set; }

  /// <summary>
  /// Combo box control that combines text input with a dropdown list.
  /// </summary>
  public ComboBox? ComboBox { get; set; }

  /// <summary>
  /// Dropdown control for selecting from a list of options.
  /// </summary>
  public DropDownRegular? DropDownRegular { get; set; }

  /// <summary>
  /// Gallery control that displays a collection of selectable items.
  /// </summary>
  public Gallery? Gallery { get; set; }

  /// <summary>
  /// Menu control that displays a dropdown list of commands.
  /// </summary>
  public Menu? Menu { get; set; }

  /// <summary>
  /// Dynamic menu control that generates menu items at runtime.
  /// </summary>
  public DynamicMenu? DynamicMenu { get; set; }

  /// <summary>
  /// Split button control that combines a default action with a dropdown menu.
  /// </summary>
  public SplitButton? SplitButton { get; set; }

  /// <summary>
  /// Box container for organizing and laying out child controls.
  /// </summary>
  public Box? Box { get; set; }

  /// <summary>
  /// Button group that clusters multiple buttons together.
  /// </summary>
  public ButtonGroup? ButtonGroup { get; set; }

  /// <summary>
  /// Separator for visual division between controls.
  /// </summary>
  public Separator? Separator { get; set; }

  /// <summary>
  /// Dialog box launcher for accessing additional options or settings.
  /// </summary>
  public DialogBoxLauncher? DialogBoxLauncher { get; set; }
}