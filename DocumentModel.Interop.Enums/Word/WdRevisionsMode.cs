namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Microsoft Word displays balloons in the margin or inline with the document's text.
/// </summary>
public enum WdRevisionsMode
{
  /// <summary>
  /// Specifies whether Microsoft Word displays balloons in the margin or inline with the document's text.
  /// </summary>
  BalloonRevisions = 0,
  /// <summary>
  /// Displays revisions within the text using strikethrough for deletions and underlining for insertions. This is
  /// the default setting for prior versions of Word.
  /// </summary>
  InLineRevisions = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  MixedRevisions = 2
}
