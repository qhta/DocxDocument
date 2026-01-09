namespace DocumentModel;

/// <summary>
/// Represents a gallery control that displays a collection of items in a grid layout within the ribbon, supporting dynamic content, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a gallery control that presents a visual collection of selectable items arranged in rows and columns. Galleries provide rich visual selection interfaces with customizable item appearance, dimensions, labels, and images. They support both static and dynamic content generation through callback functions.
/// </remarks>
public interface Gallery : CustomUIControl, BuiltInControl, BoxContent, GroupContent, TaggedObject
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
  /// Description text for the gallery control.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

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
  /// Callback executed when a gallery item is selected.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Enable interaction with the gallery.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Custom image identifier for the gallery button.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the gallery button.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic gallery image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Show item images in the gallery.
  /// </summary>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  /// Callback for dynamic item count.
  /// </summary>
  public string? GetItemCount { get; set; }

  /// <summary>
  /// Callback for dynamic item label.
  /// </summary>
  public string? GetItemLabel { get; set; }

  /// <summary>
  /// Callback for dynamic item screentip.
  /// </summary>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  /// Callback for dynamic item supertip.
  /// </summary>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  /// Callback for dynamic item image.
  /// </summary>
  public string? GetItemImage { get; set; }

  /// <summary>
  /// Callback for dynamic item identifier.
  /// </summary>
  public string? GetItemID { get; set; }

  /// <summary>
  /// String representation of the gallery size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Callback for dynamic selected item identifier.
  /// </summary>
  public string? GetSelectedItemID { get; set; }

  /// <summary>
  /// Callback for dynamic selected item index.
  /// </summary>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Screentip text for the gallery.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the gallery.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Label text for the gallery.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the gallery in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the gallery.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the gallery label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the gallery image in the UI.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  /// Callback for dynamic image visibility.
  /// </summary>
  public string? GetShowImage { get; set; }

  /// <summary>
  /// Collection of static items displayed in the gallery.
  /// </summary>
  public SelectionItems? Items { get; set; }

  /// <summary>
  /// Collection of button controls that can be displayed in the gallery.
  /// </summary>
  public RegularButtonsList? ButtonRegulars { get; set; }
}