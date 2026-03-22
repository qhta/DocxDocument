namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pending changes should be handled.
/// </summary>
public enum WdSaveOptions
{
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  wdDoNotSaveChanges = unchecked((int)0),
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  wdPromptToSaveChanges = unchecked((int)-2),
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  wdSaveChanges = unchecked((int)-1)
}
