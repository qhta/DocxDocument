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
  Margin = 0,
  /// <summary>
  /// Word calculates tab alignment relative to the paragraph indents.
  /// </summary>
  Indent = 1
}
