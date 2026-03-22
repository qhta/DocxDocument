namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies action to take when a user clicks an item in the task pane.
/// </summary>
public enum MsoFileNewAction
{
  /// <summary>
  /// Edit file.
  /// </summary>
  msoEditFile,
  /// <summary>
  /// Create a new file.
  /// </summary>
  msoCreateNewFile,
  /// <summary>
  /// Open file.
  /// </summary>
  msoOpenFile
}
