namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction to flow the text in a document.
/// </summary>
public enum WdDocumentDirection
{
  /// <summary>
  /// Left to right.
  /// </summary>
  LeftToRight = unchecked((int)0),
  /// <summary>
  /// Right to left.
  /// </summary>
  RightToLeft = unchecked((int)1)
}
