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
  msoFileDialogViewList = 1,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  msoFileDialogViewDetails,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  msoFileDialogViewProperties,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  msoFileDialogViewPreview,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  msoFileDialogViewThumbnail,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  msoFileDialogViewLargeIcons,
  /// <summary>
  /// Specifies the view presented to the user in a file dialog box.
  /// </summary>
  msoFileDialogViewSmallIcons,
  /// <summary>
  /// Files displayed in Web view.
  /// </summary>
  msoFileDialogViewWebView,
  /// <summary>
  /// Files displayed as tiled icons.
  /// </summary>
  msoFileDialogViewTiles
}
