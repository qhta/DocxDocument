namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Word displays the original version of a document or a version with revisions and formatting
/// changes applied.
/// </summary>
public enum WdRevisionsView
{
  /// <summary>
  /// Specifies whether Word displays the original version of a document or a version with revisions and formatting
  /// changes applied.
  /// </summary>
  wdRevisionsViewFinal = unchecked((int)0),
  /// <summary>
  /// Specifies whether Word displays the original version of a document or a version with revisions and formatting
  /// changes applied.
  /// </summary>
  wdRevisionsViewOriginal = unchecked((int)1)
}
