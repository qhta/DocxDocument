namespace DocumentModel;

/// <summary>
///   Represents a regular dropdown control that displays a list of selectable items, suitable for use within menus and button groups.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a streamlined dropdown control optimized for use
///   within constrained ribbon contexts such as menus, button groups, and other containers. Unlike the standard dropdown
///   control which may have additional sizing options, DropDownRegular provides a simplified dropdown implementation
///   that maintains consistent dimensions appropriate for its context. The control allows users to select from a
///   predefined list of options displayed in a dropdown menu. It supports both static and dynamic content generation,
///   customizable appearance with images and labels for both the control and its items, selection tracking, and can
///   have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface DropDownRegular : IModelElement
{
  /// <summary>
  ///   Gets or sets the name of the callback function executed when a dropdown item is selected.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the dropdown is enabled and can be interacted with.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the dropdown is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the dropdown should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the dropdown button icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the dropdown button icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the dropdown button.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dropdown's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether item images are displayed in the dropdown list.
  /// </summary>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the total number of items in the dropdown list.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an integer representing the item count.
  ///   Use this for dynamically generated dropdown content.
  /// </remarks>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the label for a specific dropdown item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return a string label.
  /// </remarks>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the screentip for a specific dropdown item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return a string screentip.
  /// </remarks>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the supertip for a specific dropdown item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return a string supertip (extended tooltip).
  /// </remarks>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the image for a specific dropdown item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return an image object or identifier.
  /// </remarks>
  public string? GetItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the unique identifier for a specific dropdown item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return a string identifier.
  /// </remarks>
  public string? GetItemID { get; set; }

  /// <summary>
  ///   Gets or sets the string representation of the dropdown size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the identifier of the currently selected item.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string identifier of the selected item.
  /// </remarks>
  public string? GetSelectedItemID { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the index of the currently selected item.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an integer index of the selected item.
  /// </remarks>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether item labels are displayed in the dropdown list.
  /// </summary>
  public bool? ShowItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this dropdown.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this dropdown.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this dropdown.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office dropdown.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the dropdown.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dropdown's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the dropdown.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dropdown's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the dropdown.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dropdown's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this dropdown should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the dropdown relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this dropdown should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the dropdown relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this dropdown should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the dropdown relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this dropdown should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the dropdown relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the dropdown is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dropdown's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the dropdown should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the dropdown.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the dropdown's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the dropdown's label should be displayed.
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
  ///   Gets or sets a value indicating whether the dropdown's image should be displayed.
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
  ///   Gets or sets the collection of static items displayed in the dropdown list.
  /// </summary>
  public Collection<Item>? Items { get; set; }

  /// <summary>
  ///   Gets or sets the collection of button controls that can be displayed in the dropdown.
  /// </summary>
  public Collection<ButtonRegular>? ButtonRegulars { get; set; }
}