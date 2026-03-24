namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pending changes should be handled.
/// </summary>
public enum WdSaveOptions
{
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  DoNotSaveChanges = 0,
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  PromptToSaveChanges = -2,
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  SaveChanges = -1
}
