namespace DocumentModel.Application;

/// <summary>
/// Specifies the view presented to the user in a file dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiledialogview?view=office-pia` for Office interop details.
/// </remarks>
public enum FileDialogView
{
  /// <summary>
  /// Files displayed in a list without details.
  /// </summary>
  List = 1,
  /// <summary>
  /// Files displayed in a list with detail information.
  /// </summary>
  Details,
  /// <summary>
  /// Files displayed in a list with a pane showing the selected file's properties.
  /// </summary>
  Properties,
  /// <summary>
  /// Files displayed in a list with a preview pane showing the selected file.
  /// </summary>
  Preview,
  /// <summary>
  /// Files displayed as thumbnails.
  /// </summary>
  Thumbnail,
  /// <summary>
  /// Files displayed as large icons.
  /// </summary>
  LargeIcons,
  /// <summary>
  /// Files displayed as small icons.
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
