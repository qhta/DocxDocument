namespace DocumentModel;

/// <summary>
///   Represents a combo box control that combines text input with a dropdown list of selectable items.
/// </summary>
/// <remarks>
///   This interface defines a combo box control that allows users
///   to either type text directly or select from a predefined list of options. Unlike a simple dropdown,
///   the combo box provides an editable text field, making it suitable for scenarios where users need
///   flexibility to enter custom values or select from suggestions. The control supports both static and
///   dynamic content generation, customizable appearance with images and labels, text length constraints,
///   and change notifications. It can have its state and behavior controlled through static properties
///   or dynamic callbacks.
/// </remarks>
public interface ComboBox :
{
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
  ///   Gets or sets the string representation of the combo box size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the dropdown content should be invalidated when the dropdown is closed.
  /// </summary>
  /// <remarks>
  ///   When enabled, the dropdown content will be refreshed each time the dropdown is opened.
  /// </remarks>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the combo box is enabled and can be interacted with.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the combo box is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the combo box should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the combo box icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the combo box icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the combo box.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the maximum number of characters that can be entered in the text field.
  /// </summary>
  /// <remarks>
  ///   This constraint applies to text typed directly into the combo box, not to selected items.
  /// </remarks>
  public Int64? MaxLength { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the current text value of the combo box.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string representing the current text in the combo box.
  /// </remarks>
  public string? GetText { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when the combo box text changes.
  /// </summary>
  /// <remarks>
  ///   The callback function is invoked when the user types text or selects an item from the dropdown.
  /// </remarks>
  public string? OnChange { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this combo box.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this combo box.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this combo box.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office combo box.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the combo box.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the combo box.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the combo box.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this combo box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the combo box relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this combo box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the combo box relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this combo box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the combo box relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this combo box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the combo box relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the combo box is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the combo box should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the combo box.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the combo box's label should be displayed.
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
  ///   Gets or sets a value indicating whether the combo box's image should be displayed.
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
}