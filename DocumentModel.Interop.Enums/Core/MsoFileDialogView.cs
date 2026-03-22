namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the view presented to the user in a file dialog box.
/// </summary>
public enum MsoFileDialogView
{
  /// <summary>
  /// Files displayed in a list without details. msoFileDialogViewDetails2 Files displayed in a list with detail
  /// information. msoFileDialogViewProperties3 Files displayed in a list with a pane showing the selected file's
  /// properties. msoFileDialogViewPreview4 Files displayed in a list with a preview pane showing the selected file.
  /// msoFileDialogViewThumbnail5 Files displayed as thumbnails. msoFileDialogViewLargeIcons6 Files displayed as
  /// large icons. msoFileDialogViewSmallIcons7 Files displayed as small icons.
  /// </summary>
  List = 1,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  Details,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  Properties,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  Preview,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  Thumbnail,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  LargeIcons,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  SmallIcons,
  /// <summary>
  /// Files displayed in Web view.
  /// </summary>
  WebView,
  /// <summary>
  /// Files displayed as tiled icons.
  /// </summary>
  Tiles
}
