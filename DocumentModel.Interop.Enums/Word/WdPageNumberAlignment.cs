namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment to apply to page numbers.
/// </summary>
public enum WdPageNumberAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  Left = unchecked((int)0),
  /// <summary>
  /// Centered.
  /// </summary>
  Center = unchecked((int)1),
  /// <summary>
  /// Right-aligned.
  /// </summary>
  Right = unchecked((int)2),
  /// <summary>
  /// Left-aligned just inside the footer.
  /// </summary>
  Inside = unchecked((int)3),
  /// <summary>
  /// Right-aligned just outside the footer.
  /// </summary>
  Outside = unchecked((int)4)
}
