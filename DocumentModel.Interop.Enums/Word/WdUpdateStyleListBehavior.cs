namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the behavior Word 2010 should take when updating a style to match a selection that contains
/// numbering or bullets.
/// </summary>
public enum WdUpdateStyleListBehavior
{
  /// <summary>
  /// Keeps the existing numbering or bullets pattern for all other paragraphs that use the same style and does not
  /// apply the numbering or bullets pattern of the selection. wdListBehaviorAddBulletsNumbering1 Adds the numbering
  /// or bullets pattern of the selection to all paragraphs in the document that use the same style.
  /// </summary>
  wdListBehaviorKeepPreviousPattern = unchecked((int)0),
  /// <summary>
  /// Specifies the behavior Word 2010 should take when updating a style to match a selection that contains
  /// numbering or bullets.
  /// </summary>
  wdListBehaviorAddBulletsNumbering = unchecked((int)1)
}
