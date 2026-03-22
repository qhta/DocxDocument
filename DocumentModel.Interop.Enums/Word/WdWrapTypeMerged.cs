namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word wraps text around pictures.
/// </summary>
public enum WdWrapTypeMerged
{
  /// <summary>
  /// In line with text.
  /// </summary>
  wdWrapMergeInline = unchecked((int)0),
  /// <summary>
  /// Square.
  /// </summary>
  wdWrapMergeSquare = unchecked((int)1),
  /// <summary>
  /// Tight.
  /// </summary>
  wdWrapMergeTight = unchecked((int)2),
  /// <summary>
  /// Behind text.
  /// </summary>
  wdWrapMergeBehind = unchecked((int)3),
  /// <summary>
  /// In front of text.
  /// </summary>
  wdWrapMergeFront = unchecked((int)4),
  /// <summary>
  /// Through.
  /// </summary>
  wdWrapMergeThrough = unchecked((int)5),
  /// <summary>
  /// Top and bottom.
  /// </summary>
  wdWrapMergeTopBottom = unchecked((int)6)
}
