namespace DocumentModel;

/// <summary>
/// Represents a menu control that displays a dropdown list of commands and controls in the ribbon interface, supporting hierarchical organization, customizable appearance, and dynamic integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a menu control that presents a hierarchical collection of commands when clicked. Menus can contain various child controls including buttons, checkboxes, galleries, toggle buttons, separators, split buttons, and nested menus. They support customizable appearance with images, labels, tooltips, sizing options, and can have their state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface Menu : BoxContentControl
{
  /// <summary>
  /// Size of the menu control in the ribbon.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  /// Callback for dynamic menu size.
  /// </summary>
  public string? GetSize { get; set; }

  /// <summary>
  /// Size of items within the menu.
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

  /// <summary>
  /// Description text for the menu control.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Built-in Office identifier for a menu.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  /// Custom image identifier for the menu button.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the menu button.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic menu image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Screentip text for the menu.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the menu.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Enable interaction with the menu.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label displayed for the menu.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the menu in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the menu.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the menu label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the menu image in the UI.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  /// Callback for dynamic image visibility.
  /// </summary>
  public string? GetShowImage { get; set; }

  /// <summary>
  /// Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  /// Regular button control that executes an action when clicked.
  /// </summary>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  /// Checkbox control for boolean selection.
  /// </summary>
  public CheckBox? CheckBox { get; set; }

  /// <summary>
  /// Regular gallery control that displays a collection of selectable items.
  /// </summary>
  public GalleryRegular? GalleryRegular { get; set; }

  /// <summary>
  /// Regular toggle button control that maintains an on/off state.
  /// </summary>
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  /// <summary>
  /// Separator for visual division between menu items.
  /// </summary>
  public MenuSeparator? MenuSeparator { get; set; }

  /// <summary>
  /// Regular split button control that combines a default action with a dropdown menu.
  /// </summary>
  public SplitButtonRegular? SplitButtonRegular { get; set; }

  /// <summary>
  /// Nested regular menu control for hierarchical menu organization.
  /// </summary>
  public MenuRegular? MenuRegular { get; set; }

  /// <summary>
  /// Dynamic regular menu control that generates menu items at runtime.
  /// </summary>
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }
}