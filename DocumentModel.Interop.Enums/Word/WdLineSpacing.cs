namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a line spacing format to be applied to a paragraph.
/// </summary>
public enum WdLineSpacing
{
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  wdLineSpaceSingle = unchecked((int)0),
  /// <summary>
  /// Space-and-a-half line spacing. Spacing is equivalent to the current font size
  /// </summary>
  wdLineSpace1pt5 = unchecked((int)1),
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  wdLineSpaceDouble = unchecked((int)2),
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  wdLineSpaceAtLeast = unchecked((int)3),
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  wdLineSpaceExactly = unchecked((int)4),
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  wdLineSpaceMultiple = unchecked((int)5)
}
