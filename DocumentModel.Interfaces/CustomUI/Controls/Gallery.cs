namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a gallery control that displays a collection of items in a grid layout within the ribbon, supporting dynamic content, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a gallery control that presents a visual collection of selectable items arranged in rows and columns. Galleries provide rich visual selection interfaces with customizable item appearance, dimensions, labels, and images. They support both static and dynamic content generation through callback functions.
/// </remarks>
public interface Gallery : CustomUIControl, BuiltInObject, TaggedObject, 
  DescriptionControl,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ActionControl,
  ItemsControl, SelectedItemControl,
  SelectionItemCollection,
  BoxContent, GroupContent
{
  /// <summary>
  /// Size of the gallery control in the ribbon.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  /// Callback for dynamic gallery size.
  /// </summary>
  public string? GetSize { get; set; }

  /// <summary>
  /// Invalidate gallery content when the dropdown is closed.
  /// </summary>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  /// Number of columns in the gallery layout.
  /// </summary>
  public Int64? Columns { get; set; }

  /// <summary>
  /// Number of rows in the gallery layout.
  /// </summary>
  public Int64? Rows { get; set; }

  /// <summary>
  /// Width of each item in the gallery.
  /// </summary>
  public Int64? ItemWidth { get; set; }

  /// <summary>
  /// Height of each item in the gallery.
  /// </summary>
  public Int64? ItemHeight { get; set; }

  /// <summary>
  /// Callback for dynamic item width.
  /// </summary>
  public string? GetItemWidth { get; set; }

  /// <summary>
  /// Callback for dynamic item height.
  /// </summary>
  public string? GetItemHeight { get; set; }

  /// <summary>
  /// Show item labels in the gallery.
  /// </summary>
  public bool? ShowItemLabel { get; set; }

  /// <summary>
  /// Gallery display mode in the ribbon interface.
  /// </summary>
  public GalleryShowInRibbonKind? ShowInRibbon { get; set; }

  /// <summary>
  /// String representation of the gallery size.
  /// </summary>
  public string? SizeString { get; set; }

}