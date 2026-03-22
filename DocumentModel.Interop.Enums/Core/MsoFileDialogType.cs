namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of a FileDialog object.
/// </summary>
public enum MsoFileDialogType
{
  /// <summary>
  /// Open dialog box.
  /// </summary>
  msoFileDialogOpen = 1,
  /// <summary>
  /// Save As dialog box.
  /// </summary>
  msoFileDialogSaveAs,
  /// <summary>
  /// File picker dialog box.
  /// </summary>
  msoFileDialogFilePicker,
  /// <summary>
  /// Folder picker dialog box.
  /// </summary>
  msoFileDialogFolderPicker
}
