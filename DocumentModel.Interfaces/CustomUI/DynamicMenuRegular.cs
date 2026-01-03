namespace DocumentModel;

/// <summary>
///   Represents a regular dynamic menu control that generates menu items at runtime, suitable for use within menus and button groups.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a streamlined dynamic menu control optimized for use
///   within constrained ribbon contexts such as menus, button groups, and other containers. Unlike the standard
///   <see cref="DynamicMenu"/> control which has additional sizing options, DynamicMenuRegular provides a simplified
///   dynamic menu implementation that maintains consistent dimensions appropriate for its context. The control creates
///   its menu content dynamically through a callback function rather than using a predefined static list of items,
///   making it ideal for context-sensitive commands, recently used items, or menus that reflect current application state.
///   The menu content can be invalidated and regenerated as needed, and the control supports customizable appearance
///   with images, labels, tooltips, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface DynamicMenuRegular : IModelElement
{
  /// <summary>
  ///   Gets or sets the description text for the dynamic menu control.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dynamic menu's description.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this dynamic menu.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this dynamic menu.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this dynamic menu.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office dynamic menu.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function that generates the dynamic menu content.
  /// </summary>
  /// <remarks>
  ///   The callback function should return XML markup defining the menu items to display.
  ///   This is the primary mechanism for creating dynamic menu content.
  /// </remarks>
  public string? GetContent { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the menu content should be invalidated when the dropdown is closed.
  /// </summary>
  /// <remarks>
  ///   When enabled, the menu content will be regenerated each time the dropdown is opened.
  /// </remarks>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the dynamic menu button.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the dynamic menu button.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the dynamic menu button.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dynamic menu's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the dynamic menu.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dynamic menu's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the dynamic menu.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dynamic menu's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the dynamic menu is enabled and can be clicked.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the dynamic menu is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the dynamic menu should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the dynamic menu.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dynamic menu's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this dynamic menu should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the dynamic menu relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this dynamic menu should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the dynamic menu relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this dynamic menu should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the dynamic menu relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this dynamic menu should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the dynamic menu relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the dynamic menu is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dynamic menu's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the dynamic menu should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the dynamic menu.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dynamic menu's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the dynamic menu's label should be displayed.
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
  ///   Gets or sets a value indicating whether the dynamic menu's image should be displayed.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the image is shown.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the image should be displayed.
  /// </remarks>
  public string? GetShowImage { get; set; }
}