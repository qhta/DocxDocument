namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pending changes should be handled.
/// </summary>
public enum WdSaveOptions
{
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  DoNotSaveChanges = unchecked((int)0),
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  PromptToSaveChanges = unchecked((int)-2),
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  SaveChanges = unchecked((int)-1)
}
