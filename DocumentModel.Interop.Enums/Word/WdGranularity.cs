namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the granularity of changes to track when comparing two documents. Version Added: Word 2007.
/// </summary>
public enum WdGranularity
{
  /// <summary>
  /// Tracks character-level changes.
  /// </summary>
  CharLevel = 0,
  /// <summary>
  /// Tracks word-level changes.
  /// </summary>
  WordLevel = 1
}
