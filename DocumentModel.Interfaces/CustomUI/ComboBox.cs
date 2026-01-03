namespace DocumentModel;

/// <summary>
///   Represents a combo box control that combines text input with a dropdown list of selectable items.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a combo box control that allows users
///   to either type text directly or select from a predefined list of options. Unlike a simple dropdown,
///   the combo box provides an editable text field, making it suitable for scenarios where users need
///   flexibility to enter custom values or select from suggestions. The control supports both static and
///   dynamic content generation, customizable appearance with images and labels, text length constraints,
///   and change notifications. It can have its state and behavior controlled through static properties
///   or dynamic callbacks.
/// </remarks>
public interface ComboBox : IModelElement
{
  /// <summary>
  ///   Gets or sets a value indicating whether item images are displayed in the dropdown list.
  /// </summary>
  /// <value>
  ///   <c>true</c> to show item images; <c>false</c> to hide them; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the total number of items in the dropdown list.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if using static items.
  /// </value>
  /// <remarks>
  ///   The callback function should return an integer representing the item count.
  ///   Use this for dynamically generated dropdown content.
  /// </remarks>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the label for a specific dropdown item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic labels.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return a string label.
  /// </remarks>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the screentip for a specific dropdown item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic screentips.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return a string screentip.
  /// </remarks>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the supertip for a specific dropdown item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic supertips.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return a string supertip (extended tooltip).
  /// </remarks>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the image for a specific dropdown item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic images.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return an image object or identifier.
  /// </remarks>
  public string? GetItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the unique identifier for a specific dropdown item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic item IDs.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return a string identifier.
  /// </remarks>
  public string? GetItemID { get; set; }

  /// <summary>
  ///   Gets or sets the string representation of the combo box size.
  /// </summary>
  /// <value>
  ///   A string containing the size value, or <c>null</c> if not specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? SizeString { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the dropdown content should be invalidated when the dropdown is closed.
  /// </summary>
  /// <value>
  ///   <c>true</c> to invalidate content on dropdown close; <c>false</c> otherwise; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  ///   When enabled, the dropdown content will be refreshed each time the dropdown is opened.
  /// </remarks>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the combo box is enabled and can be interacted with.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the combo box is enabled; <c>false</c> if disabled; or <c>null</c> to use the default enabled state.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the combo box is enabled.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the enabled state is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the combo box should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the combo box icon.
  /// </summary>
  /// <value>
  ///   A string containing the image identifier, or <c>null</c> if no custom image is specified.
  /// </value>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the combo box icon.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office image identifier, or <c>null</c> if not using a built-in image.
  /// </value>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the combo box.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's image.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the image is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the maximum number of characters that can be entered in the text field.
  /// </summary>
  /// <value>
  ///   An integer representing the maximum character length, or <c>null</c> to allow unlimited input.
  /// </value>
  /// <remarks>
  ///   This constraint applies to text typed directly into the combo box, not to selected items.
  /// </remarks>
  public Int64? MaxLength { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the current text value of the combo box.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not retrieving text dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string representing the current text in the combo box.
  /// </remarks>
  public string? GetText { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when the combo box text changes.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if no change handler is defined.
  /// </value>
  /// <remarks>
  ///   The callback function is invoked when the user types text or selects an item from the dropdown.
  /// </remarks>
  public string? OnChange { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this combo box.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this combo box.
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
  ///   The tag can be used to store application-specific information associated with this combo box.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office combo box.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in combo box.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the combo box.
  /// </summary>
  /// <value>
  ///   A string containing the screentip text, or <c>null</c> if no screentip is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's screentip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the screentip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the combo box.
  /// </summary>
  /// <value>
  ///   A string containing the supertip text, or <c>null</c> if no supertip is specified.
  /// </value>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's supertip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the supertip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the combo box.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's label.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the label is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this combo box should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the combo box relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this combo box should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the combo box relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this combo box should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the combo box relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this combo box should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the combo box relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the combo box is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the combo box is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the combo box should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the combo box.
  /// </summary>
  /// <value>
  ///   A string containing the keytip character(s), or <c>null</c> if no keytip is specified.
  /// </value>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the combo box's keytip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the keytip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the combo box's label should be displayed.
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
  ///   Gets or sets a value indicating whether the combo box's image should be displayed.
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
  ///   Gets or sets the collection of static items displayed in the dropdown list.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="Item"/> objects, or <c>null</c> if using dynamic content generation.
  /// </value>
  public Collection<Item>? Items { get; set; }
}