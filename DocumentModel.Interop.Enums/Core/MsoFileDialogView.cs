namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the view presented to the user in a file dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiledialogview?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFileDialogView))]
public enum FileDialogView
{
  /// <summary>
  /// Files displayed in a list without details.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewList))]
  List = 1,
  /// <summary>
  /// Files displayed in a list with detail information.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewDetails))]
  Details,
  /// <summary>
  /// Files displayed in a list with a pane showing the selected file's properties.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewProperties))]
  Properties,
  /// <summary>
  /// Files displayed in a list with a preview pane showing the selected file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewPreview))]
  Preview,
  /// <summary>
  /// Files displayed as thumbnails.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewThumbnail))]
  Thumbnail,
  /// <summary>
  /// Files displayed as large icons.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewLargeIcons))]
  LargeIcons,
  /// <summary>
  /// Files displayed as small icons.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewSmallIcons))]
  SmallIcons,
  /// <summary>
  /// Files displayed in Web view.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewWebView))]
  WebView,
  /// <summary>
  /// Files displayed as tiled icons.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogView.msoFileDialogViewTiles))]
  Tiles
}
