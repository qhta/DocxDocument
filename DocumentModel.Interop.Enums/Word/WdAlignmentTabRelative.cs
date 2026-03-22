namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Microsoft Office Word calculates the alignment for a tab relative to the section margins or
/// the paragraph indents.
/// </summary>
public enum WdAlignmentTabRelative
{
  /// <summary>
  /// Word calculates tab alignment relative to the margins
  /// </summary>
  wdMargin = unchecked((int)0),
  /// <summary>
  /// Word calculates tab alignment relative to the paragraph indents.
  /// </summary>
  wdIndent = unchecked((int)1)
}
