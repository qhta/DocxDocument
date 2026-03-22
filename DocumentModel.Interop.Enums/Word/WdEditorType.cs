namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a user or group of users for a document.
/// </summary>
public enum WdEditorType
{
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  wdEditorCurrent = unchecked((int)-6),
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  wdEditorEditors = unchecked((int)-5),
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  wdEditorOwners = unchecked((int)-4),
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  wdEditorEveryone = unchecked((int)-1)
}
