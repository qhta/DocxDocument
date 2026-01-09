namespace DocumentModel;

/// <summary>
///   Represents a regular gallery control that displays a collection of items in a grid layout within ribbon groups or menus.
/// </summary>
/// <remarks>
///   This interface defines a gallery control that presents
///   a visual collection of selectable items arranged in rows and columns. Unlike the standard
///   <see cref="Gallery"/> control which has additional sizing options, GalleryRegular provides
///   a streamlined gallery implementation suitable for use within button groups and other constrained
///   ribbon contexts. Galleries support both static and dynamic content generation through callback functions.
/// </remarks>
public interface GalleryRegular: CustomUIControl, BuiltInControl, ContextMenuContent, TaggedObject
{
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
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the label for a specific gallery item.
  /// </summary>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the screentip for a specific gallery item.
  /// </summary>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the supertip for a specific gallery item.
  /// </summary>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the image for a specific gallery item.
  /// </summary>
  public string? GetItemImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the unique identifier for a specific gallery item.
  /// </summary>
  public string? GetItemID { get; set; }

  /// <summary>
  ///   Gets or sets the string representation of the gallery size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the identifier of the currently selected item.
  /// </summary>
  public string? GetSelectedItemID { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the index of the currently selected item.
  /// </summary>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the gallery.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's screentip.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the gallery.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's supertip.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the gallery.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's label.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the gallery.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the gallery's keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery's label should be displayed.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the gallery's image should be displayed.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the image is shown.
  /// </summary>
  public string? GetShowImage { get; set; }

  /// <summary>
  ///   Gets or sets the collection of static items displayed in the gallery.
  /// </summary>
  public SelectionItems? Items { get; set; }

  /// <summary>
  ///   Gets or sets the collection of button controls that can be displayed in the gallery.
  /// </summary>
  public RegularButtonsList? ButtonRegulars { get; set; }
}