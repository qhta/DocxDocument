namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of text separator to place between headings in an index.
/// </summary>
public enum WdHeadingSeparator
{
  /// <summary>
  /// No separator.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// A blank line.
  /// </summary>
  BlankLine = unchecked((int)1),
  /// <summary>
  /// A designated letter.
  /// </summary>
  Letter = unchecked((int)2),
  /// <summary>
  /// A designated lowercase letter.
  /// </summary>
  LetterLow = unchecked((int)3),
  /// <summary>
  /// A designated uppercase letter.
  /// </summary>
  LetterFull = unchecked((int)4)
}
