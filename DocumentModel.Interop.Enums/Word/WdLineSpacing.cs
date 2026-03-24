namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a line spacing format to be applied to a paragraph.
/// </summary>
public enum WdLineSpacing
{
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  Single = unchecked((int)0),
  /// <summary>
  /// Space-and-a-half line spacing. Spacing is equivalent to the current font size
  /// </summary>
  OnePtFive = unchecked((int)1),
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  Double = unchecked((int)2),
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  AtLeast = unchecked((int)3),
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  Exactly = unchecked((int)4),
  /// <summary>
  /// Specifies a line spacing format to be applied to a paragraph.
  /// </summary>
  Multiple = unchecked((int)5)
}
