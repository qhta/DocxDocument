namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies alignment for the content in selected rows.
/// </summary>
public enum WdRowAlignment
{
  /// <summary>
  /// Left aligned. default.
  /// </summary>
  wdAlignRowLeft = unchecked((int)0),
  /// <summary>
  /// Centered.
  /// </summary>
  wdAlignRowCenter = unchecked((int)1),
  /// <summary>
  /// Right aligned.
  /// </summary>
  wdAlignRowRight = unchecked((int)2)
}
