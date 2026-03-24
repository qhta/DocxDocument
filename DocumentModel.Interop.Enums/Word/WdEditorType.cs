namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a user or group of users for a document.
/// </summary>
public enum WdEditorType
{
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  Current = unchecked((int)-6),
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  Editors = unchecked((int)-5),
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  Owners = unchecked((int)-4),
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  Everyone = unchecked((int)-1)
}
