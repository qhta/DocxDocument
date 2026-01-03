namespace DocumentModel;

/// <summary>
///   Represents a menu control that displays a dropdown list of commands and controls in the ribbon interface.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a menu control that presents
///   a hierarchical collection of commands when clicked. Menus can contain various child controls
///   including buttons, checkboxes, galleries, toggle buttons, separators, split buttons, and nested menus.
///   They support customizable appearance with images, labels, tooltips, sizing options, and can have
///   their state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface Menu : IModelElement
{
  /// <summary>
  ///   Gets or sets the size of the menu control in the ribbon.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's size.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a <see cref="SizeKind"/> value.
  /// </remarks>
  public string? GetSize { get; set; }

  /// <summary>
  ///   Gets or sets the size of items within the menu.
  /// </summary>
  /// <remarks>
  ///   This controls whether menu items are displayed in a normal or large format.
  /// </remarks>
  public ItemSizeKind? ItemSize { get; set; }

  /// <summary>
  ///   Gets or sets the description text for the menu control.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's description.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this menu.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this menu.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this menu.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office menu.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the menu button.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the menu button.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the menu button.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the menu.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the menu.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu is enabled and can be clicked.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the menu is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the menu should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the menu.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this menu should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the menu relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this menu should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the menu relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this menu should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the menu relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this menu should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the menu relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the menu should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the menu.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu's label should be displayed.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the label should be displayed.
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu's image should be displayed.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the image is shown.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the image should be displayed.
  /// </remarks>
  public string? GetShowImage { get; set; }

  /// <summary>
  ///   Gets or sets a cloned instance of a built-in or custom control.
  /// </summary>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  ///   Gets or sets a regular button control that executes an action when clicked.
  /// </summary>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a checkbox control for boolean selection.
  /// </summary>
  public CheckBox? CheckBox { get; set; }

  /// <summary>
  ///   Gets or sets a regular gallery control that displays a collection of selectable items.
  /// </summary>
  public GalleryRegular? GalleryRegular { get; set; }

  /// <summary>
  ///   Gets or sets a regular toggle button control that maintains an on/off state.
  /// </summary>
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a separator that provides visual division between menu items.
  /// </summary>
  public MenuSeparator? MenuSeparator { get; set; }

  /// <summary>
  ///   Gets or sets a regular split button control that combines a default action with a dropdown menu.
  /// </summary>
  public SplitButtonRegular? SplitButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a nested regular menu control for hierarchical menu organization.
  /// </summary>
  /// <remarks>
  ///   Menus can be nested to create multi-level hierarchical navigation structures.
  /// </remarks>
  public MenuRegular? MenuRegular { get; set; }

  /// <summary>
  ///   Gets or sets a dynamic regular menu control that generates menu items at runtime.
  /// </summary>
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }
}