namespace DocumentModel;

/// <summary>
///   Represents a regular gallery control that displays a collection of items in a grid layout within ribbon groups or menus.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a gallery control that presents
///   a visual collection of selectable items arranged in rows and columns. Unlike the standard
///   <see cref="Gallery"/> control which has additional sizing options, GalleryRegular provides
///   a streamlined gallery implementation suitable for use within button groups and other constrained
///   ribbon contexts. Galleries support both static and dynamic content generation through callback functions.
/// </remarks>
public interface GalleryRegular : IModelElement
{
  /// <summary>
  ///   Gets or sets the description text for the gallery control.
  /// </summary>
  /// <value>
  ///   A string containing the description, or <c>null</c> if no description is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's description.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the description is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery content should be invalidated when the dropdown is closed.
  /// </summary>
  /// <value>
  ///   <c>true</c> to invalidate content on dropdown close; <c>false</c> otherwise; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  ///   When enabled, the gallery content will be refreshed each time the dropdown is opened.
  /// </remarks>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  ///   Gets or sets the number of columns in the gallery layout.
  /// </summary>
  /// <value>
  ///   An integer representing the column count, or <c>null</c> to use the default column count.
  /// </value>
  /// <remarks>
  /// </remarks>
  public Int64? Columns { get; set; }

  /// <summary>
  ///   Gets or sets the number of rows in the gallery layout.
  /// </summary>
  /// <value>
  ///   An integer representing the row count, or <c>null</c> to use the default row count.
  /// </value>
  /// <remarks>
  /// </remarks>
  public Int64? Rows { get; set; }

  /// <summary>
  ///   Gets or sets the width of each item in the gallery.
  /// </summary>
  /// <value>
  ///   An integer representing the item width in pixels, or <c>null</c> to use the default width.
  /// </value>
  /// <remarks>
  /// </remarks>
  public Int64? ItemWidth { get; set; }

  /// <summary>
  ///   Gets or sets the height of each item in the gallery.
  /// </summary>
  /// <value>
  ///   An integer representing the item height in pixels, or <c>null</c> to use the default height.
  /// </value>
  /// <remarks>
  /// </remarks>
  public Int64? ItemHeight { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the item width.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the item width is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return an integer value for the item width.
  /// </remarks>
  public string? GetItemWidth { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the item height.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the item height is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return an integer value for the item height.
  /// </remarks>
  public string? GetItemHeight { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether item labels are displayed.
  /// </summary>
  /// <value>
  ///   <c>true</c> to show item labels; <c>false</c> to hide them; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? ShowItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets how the gallery is displayed in the ribbon interface.
  /// </summary>
  /// <value>
  ///   A <see cref="GalleryShowInRibbonKind"/> value specifying the display mode, or <c>null</c> to use the default display.
  /// </value>
  /// <remarks>
  /// </remarks>
  public GalleryShowInRibbonKind? ShowInRibbon { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when a gallery item is selected.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if no action is defined.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? OnAction { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery is enabled and can be interacted with.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the gallery is enabled; <c>false</c> if disabled; or <c>null</c> to use the default enabled state.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the gallery is enabled.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the enabled state is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the gallery should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the gallery button.
  /// </summary>
  /// <value>
  ///   A string containing the image identifier, or <c>null</c> if no custom image is specified.
  /// </value>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the gallery button.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office image identifier, or <c>null</c> if not using a built-in image.
  /// </value>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the gallery button.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's image.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the image is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether item images are displayed.
  /// </summary>
  /// <value>
  ///   <c>true</c> to show item images; <c>false</c> to hide them; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the total number of items in the gallery.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if using static items.
  /// </value>
  /// <remarks>
  ///   The callback function should return an integer representing the item count.
  ///   Use this for dynamically generated gallery content.
  /// </remarks>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the label for a specific gallery item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic labels.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return a string label.
  /// </remarks>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the screentip for a specific gallery item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic screentips.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return a string screentip.
  /// </remarks>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the supertip for a specific gallery item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic supertips.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return a string supertip (extended tooltip).
  /// </remarks>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the image for a specific gallery item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic images.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return an image object or identifier.
  /// </remarks>
  public string? GetItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the unique identifier for a specific gallery item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not using dynamic item IDs.
  /// </value>
  /// <remarks>
  ///   The callback function receives an item index and should return a string identifier.
  /// </remarks>
  public string? GetItemID { get; set; }

  /// <summary>
  ///   Gets or sets the string representation of the gallery size.
  /// </summary>
  /// <value>
  ///   A string containing the size value, or <c>null</c> if not specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? SizeString { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the identifier of the currently selected item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not tracking selection by ID.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string identifier of the selected item.
  /// </remarks>
  public string? GetSelectedItemID { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the index of the currently selected item.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if not tracking selection by index.
  /// </value>
  /// <remarks>
  ///   The callback function should return an integer index of the selected item.
  /// </remarks>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this gallery.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this gallery.
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
  ///   The tag can be used to store application-specific information associated with this gallery.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office gallery.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in gallery.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the gallery.
  /// </summary>
  /// <value>
  ///   A string containing the screentip text, or <c>null</c> if no screentip is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's screentip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the screentip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the gallery.
  /// </summary>
  /// <value>
  ///   A string containing the supertip text, or <c>null</c> if no supertip is specified.
  /// </value>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's supertip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the supertip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the gallery.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's label.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the label is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this gallery should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the gallery relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this gallery should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the gallery relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this gallery should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the gallery relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this gallery should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the gallery relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the gallery is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the gallery should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the gallery.
  /// </summary>
  /// <value>
  ///   A string containing the keytip character(s), or <c>null</c> if no keytip is specified.
  /// </value>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's keytip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the keytip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery's label should be displayed.
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
  ///   Gets or sets a value indicating whether the gallery's image should be displayed.
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
  ///   Gets or sets the collection of static items displayed in the gallery.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="Item"/> objects, or <c>null</c> if using dynamic content generation.
  /// </value>
  public Collection<Item>? Items { get; set; }

  /// <summary>
  ///   Gets or sets the collection of button controls that can be displayed in the gallery.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="ButtonRegular"/> objects, or <c>null</c> if no buttons are defined.
  /// </value>
  public Collection<ButtonRegular>? ButtonRegulars { get; set; }
}