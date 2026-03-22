namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment to apply to page numbers.
/// </summary>
public enum WdPageNumberAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  wdAlignPageNumberLeft = unchecked((int)0),
  /// <summary>
  /// Centered.
  /// </summary>
  wdAlignPageNumberCenter = unchecked((int)1),
  /// <summary>
  /// Right-aligned.
  /// </summary>
  wdAlignPageNumberRight = unchecked((int)2),
  /// <summary>
  /// Left-aligned just inside the footer.
  /// </summary>
  wdAlignPageNumberInside = unchecked((int)3),
  /// <summary>
  /// Right-aligned just outside the footer.
  /// </summary>
  wdAlignPageNumberOutside = unchecked((int)4)
}
