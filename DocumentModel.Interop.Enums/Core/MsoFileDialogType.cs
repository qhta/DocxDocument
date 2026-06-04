namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of a FileDialog object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiledialogtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFileDialogType))]
public enum FileDialogType
{
  /// <summary>
  /// Open dialog box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogType.msoFileDialogOpen))]
  Open = 1,
  /// <summary>
  /// Save As dialog box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogType.msoFileDialogSaveAs))]
  SaveAs,
  /// <summary>
  /// File picker dialog box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogType.msoFileDialogFilePicker))]
  FilePicker,
  /// <summary>
  /// Folder picker dialog box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileDialogType.msoFileDialogFolderPicker))]
  FolderPicker
}
