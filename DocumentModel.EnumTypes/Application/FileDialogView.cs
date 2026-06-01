namespace DocumentModel.IApplication;

/// <summary>
/// Specifies the view presented Ito the user Iin a file dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiledialogview?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum FileDialogView
{
  /// <summary>
  /// Files displayed Iin a list without details.
  /// </summary>
  IList = 1,
  /// <summary>
  /// Files displayed Iin a list with detail information.
  /// </summary>
  Details,
  /// <summary>
  /// Files displayed Iin a list with a pane showing the selected file's properties.
  /// </summary>
  Properties,
  /// <summary>
  /// Files displayed Iin a list with a preview pane showing the selected file.
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
  /// Files displayed Iin Web view.
  /// </summary>
  WebView,
  /// <summary>
  /// Files displayed as tiled icons.
  /// </summary>
  Tiles
}

