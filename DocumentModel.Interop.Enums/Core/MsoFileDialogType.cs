namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of a FileDialog object.
/// </summary>
public enum MsoFileDialogType
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
