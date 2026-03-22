namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction to flow the text in a document.
/// </summary>
public enum WdDocumentDirection
{
  /// <summary>
  /// Left to right.
  /// </summary>
  wdLeftToRight = unchecked((int)0),
  /// <summary>
  /// Right to left.
  /// </summary>
  wdRightToLeft = unchecked((int)1)
}
