namespace DocumentModel;

/// <summary>
///   Represents a gallery control that displays a collection of items in a grid layout within the ribbon.
/// </summary>
/// <remarks>
///   This interface defines a gallery control that presents
///   a visual collection of selectable items arranged in rows and columns. Galleries provide rich
///   visual selection interfaces with customizable item appearance, dimensions, labels, and images.
///   They support both static and dynamic content generation through callback functions.
/// </remarks>
public interface Gallery : BoxContentControl
{
  /// <summary>
  ///   Gets or sets the size of the gallery control in the ribbon.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's size.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a <see cref="SizeKind"/> value.
  /// </remarks>
  public string? GetSize { get; set; }

  /// <summary>
  ///   Gets or sets the description text for the gallery control.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's description.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery content should be invalidated when the dropdown is closed.
  /// </summary>
  /// <remarks>
  ///   When enabled, the gallery content will be refreshed each time the dropdown is opened.
  /// </remarks>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  ///   Gets or sets the number of columns in the gallery layout.
  /// </summary>
  public Int64? Columns { get; set; }

  /// <summary>
  ///   Gets or sets the number of rows in the gallery layout.
  /// </summary>
  public Int64? Rows { get; set; }

  /// <summary>
  ///   Gets or sets the width of each item in the gallery.
  /// </summary>
  public Int64? ItemWidth { get; set; }

  /// <summary>
  ///   Gets or sets the height of each item in the gallery.
  /// </summary>
  public Int64? ItemHeight { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the item width.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an integer value for the item width.
  /// </remarks>
  public string? GetItemWidth { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the item height.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an integer value for the item height.
  /// </remarks>
  public string? GetItemHeight { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether item labels are displayed.
  /// </summary>
  public bool? ShowItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets how the gallery is displayed in the ribbon interface.
  /// </summary>
  public GalleryShowInRibbonKind? ShowInRibbon { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when a gallery item is selected.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery is enabled and can be interacted with.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the gallery is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the gallery should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the gallery button.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the gallery button.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the gallery button.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether item images are displayed.
  /// </summary>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the total number of items in the gallery.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an integer representing the item count.
  ///   Use this for dynamically generated gallery content.
  /// </remarks>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the label for a specific gallery item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return a string label.
  /// </remarks>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the screentip for a specific gallery item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return a string screentip.
  /// </remarks>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the supertip for a specific gallery item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return a string supertip (extended tooltip).
  /// </remarks>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the image for a specific gallery item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return an image object or identifier.
  /// </remarks>
  public string? GetItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the unique identifier for a specific gallery item.
  /// </summary>
  /// <remarks>
  ///   The callback function receives an item index and should return a string identifier.
  /// </remarks>
  public string? GetItemID { get; set; }

  /// <summary>
  ///   Gets or sets the string representation of the gallery size.
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
  ///   Gets or sets the unique identifier for this gallery.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this gallery.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this gallery.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office gallery.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the gallery.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the gallery.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the gallery.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this gallery should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the gallery relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this gallery should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the gallery relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this gallery should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the gallery relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this gallery should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the gallery relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the gallery should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the gallery.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery's label should be displayed.
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
  ///   Gets or sets a value indicating whether the gallery's image should be displayed.
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
  ///   Gets or sets the collection of static items displayed in the gallery.
  /// </summary>
  public SelectionItems? Items { get; set; }

  /// <summary>
  ///   Gets or sets the collection of button controls that can be displayed in the gallery.
  /// </summary>
  public ButtonRegulars? ButtonRegulars { get; set; }
}