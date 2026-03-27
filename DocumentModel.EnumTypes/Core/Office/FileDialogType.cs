namespace DocumentModel.Application;

/// <summary>
/// Specifies the type of a FileDialog object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiledialogtype?view=office-pia` for Office interop details.
/// </remarks>
public enum FileDialogType
{
  /// <summary>
  /// Open dialog box.
  /// </summary>
  Open = 1,
  /// <summary>
  /// Save As dialog box.
  /// </summary>
  SaveAs,
  /// <summary>
  /// File picker dialog box.
  /// </summary>
  FilePicker,
  /// <summary>
  /// Folder picker dialog box.
  /// </summary>
  FolderPicker
}
