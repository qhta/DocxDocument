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
  /// <value>
  ///   A <see cref="SizeKind"/> value specifying the menu size, or <c>null</c> to use the default size.
  /// </value>
  /// <remarks>
  /// </remarks>
  public SizeKind? Size { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's size.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the size is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a <see cref="SizeKind"/> value.
  /// </remarks>
  public string? GetSize { get; set; }

  /// <summary>
  ///   Gets or sets the size of items within the menu.
  /// </summary>
  /// <value>
  ///   An <see cref="ItemSizeKind"/> value specifying the size of menu items, or <c>null</c> to use the default item size.
  /// </value>
  /// <remarks>
  ///   This controls whether menu items are displayed in a normal or large format.
  /// </remarks>
  public ItemSizeKind? ItemSize { get; set; }

  /// <summary>
  ///   Gets or sets the description text for the menu control.
  /// </summary>
  /// <value>
  ///   A string containing the description, or <c>null</c> if no description is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's description.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the description is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this menu.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this menu.
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
  ///   The tag can be used to store application-specific information associated with this menu.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office menu.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in menu.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the menu button.
  /// </summary>
  /// <value>
  ///   A string containing the image identifier, or <c>null</c> if no custom image is specified.
  /// </value>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the menu button.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office image identifier, or <c>null</c> if not using a built-in image.
  /// </value>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the menu button.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's image.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the image is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the menu.
  /// </summary>
  /// <value>
  ///   A string containing the screentip text, or <c>null</c> if no screentip is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's screentip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the screentip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the menu.
  /// </summary>
  /// <value>
  ///   A string containing the supertip text, or <c>null</c> if no supertip is specified.
  /// </value>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's supertip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the supertip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu is enabled and can be clicked.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the menu is enabled; <c>false</c> if disabled; or <c>null</c> to use the default enabled state.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the menu is enabled.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the enabled state is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the menu should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the menu.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's label.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the label is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this menu should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the menu relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this menu should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the menu relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this menu should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the menu relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this menu should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the menu relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the menu is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the menu should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the menu.
  /// </summary>
  /// <value>
  ///   A string containing the keytip character(s), or <c>null</c> if no keytip is specified.
  /// </value>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the menu's keytip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the keytip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu's label should be displayed.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the label is shown; <c>false</c> if hidden; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if label visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the label should be displayed.
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu's image should be displayed.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the image is shown; <c>false</c> if hidden; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the image is shown.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if image visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the image should be displayed.
  /// </remarks>
  public string? GetShowImage { get; set; }

  /// <summary>
  ///   Gets or sets a cloned instance of a built-in or custom control.
  /// </summary>
  /// <value>
  ///   A <see cref="ControlCloneRegular"/> object, or <c>null</c> if no control clone is defined.
  /// </value>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  ///   Gets or sets a regular button control that executes an action when clicked.
  /// </summary>
  /// <value>
  ///   A <see cref="ButtonRegular"/> object, or <c>null</c> if no button is defined.
  /// </value>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a checkbox control for boolean selection.
  /// </summary>
  /// <value>
  ///   A <see cref="CheckBox"/> object, or <c>null</c> if no checkbox is defined.
  /// </value>
  public CheckBox? CheckBox { get; set; }

  /// <summary>
  ///   Gets or sets a regular gallery control that displays a collection of selectable items.
  /// </summary>
  /// <value>
  ///   A <see cref="GalleryRegular"/> object, or <c>null</c> if no gallery is defined.
  /// </value>
  public GalleryRegular? GalleryRegular { get; set; }

  /// <summary>
  ///   Gets or sets a regular toggle button control that maintains an on/off state.
  /// </summary>
  /// <value>
  ///   A <see cref="ToggleButtonRegular"/> object, or <c>null</c> if no toggle button is defined.
  /// </value>
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a separator that provides visual division between menu items.
  /// </summary>
  /// <value>
  ///   A <see cref="MenuSeparator"/> object, or <c>null</c> if no separator is defined.
  /// </value>
  public MenuSeparator? MenuSeparator { get; set; }

  /// <summary>
  ///   Gets or sets a regular split button control that combines a default action with a dropdown menu.
  /// </summary>
  /// <value>
  ///   A <see cref="SplitButtonRegular"/> object, or <c>null</c> if no split button is defined.
  /// </value>
  public SplitButtonRegular? SplitButtonRegular { get; set; }

  /// <summary>
  ///   Gets or sets a nested regular menu control for hierarchical menu organization.
  /// </summary>
  /// <value>
  ///   A <see cref="MenuRegular"/> object, or <c>null</c> if no nested menu is defined.
  /// </value>
  /// <remarks>
  ///   Menus can be nested to create multi-level hierarchical navigation structures.
  /// </remarks>
  public MenuRegular? MenuRegular { get; set; }

  /// <summary>
  ///   Gets or sets a dynamic regular menu control that generates menu items at runtime.
  /// </summary>
  /// <value>
  ///   A <see cref="DynamicMenuRegular"/> object, or <c>null</c> if no dynamic menu is defined.
  /// </value>
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }
}