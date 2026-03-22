namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of text separator to place between headings in an index.
/// </summary>
public enum WdHeadingSeparator
{
  /// <summary>
  /// No separator.
  /// </summary>
  wdHeadingSeparatorNone = unchecked((int)0),
  /// <summary>
  /// A blank line.
  /// </summary>
  wdHeadingSeparatorBlankLine = unchecked((int)1),
  /// <summary>
  /// A designated letter.
  /// </summary>
  wdHeadingSeparatorLetter = unchecked((int)2),
  /// <summary>
  /// A designated lowercase letter.
  /// </summary>
  wdHeadingSeparatorLetterLow = unchecked((int)3),
  /// <summary>
  /// A designated uppercase letter.
  /// </summary>
  wdHeadingSeparatorLetterFull = unchecked((int)4)
}
