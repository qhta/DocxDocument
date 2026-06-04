namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of a FileDialog object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiledialogtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoFileDialogType")]
public enum FileDialogType
{
  /// <summary>
  /// Open dialog box.
  /// </summary>
  [InteropEnumValue("msoFileDialogOpen")]
  Open = 1,
  /// <summary>
  /// Save As dialog box.
  /// </summary>
  [InteropEnumValue("msoFileDialogSaveAs")]
  SaveAs,
  /// <summary>
  /// File picker dialog box.
  /// </summary>
  [InteropEnumValue("msoFileDialogFilePicker")]
  FilePicker,
  /// <summary>
  /// Folder picker dialog box.
  /// </summary>
  [InteropEnumValue("msoFileDialogFolderPicker")]
  FolderPicker
}
