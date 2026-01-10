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
public interface GalleryRegular: CustomUIControl, BuiltInControl, TaggedObject, 
  DescriptionControl,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  ScreentipControl, SupertipControl, KeytipControl,
  ActionControl,
  ItemsControl, SelectedItemControl,
  SelectionItemCollection,
  ContextMenuContent, MenuContent, MenuRegularContent, ButtonGroupContent
{

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
  ///   Gets or sets the string representation of the gallery size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Collection of regular buttons within the gallery.
  /// </summary>
  public RegularButtonsCollection RegularButtons { get; set; }
}