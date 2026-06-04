namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the view presented to the user in a file dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiledialogview?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoFileDialogView")]
public enum FileDialogView
{
  /// <summary>
  /// Files displayed in a list without details.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewList")]
  List = 1,
  /// <summary>
  /// Files displayed in a list with detail information.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewDetails")]
  Details,
  /// <summary>
  /// Files displayed in a list with a pane showing the selected file's properties.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewProperties")]
  Properties,
  /// <summary>
  /// Files displayed in a list with a preview pane showing the selected file.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewPreview")]
  Preview,
  /// <summary>
  /// Files displayed as thumbnails.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewThumbnail")]
  Thumbnail,
  /// <summary>
  /// Files displayed as large icons.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewLargeIcons")]
  LargeIcons,
  /// <summary>
  /// Files displayed as small icons.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewSmallIcons")]
  SmallIcons,
  /// <summary>
  /// Files displayed in Web view.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewWebView")]
  WebView,
  /// <summary>
  /// Files displayed as tiled icons.
  /// </summary>
  [InteropEnumValue("msoFileDialogViewTiles")]
  Tiles
}
