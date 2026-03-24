namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of text separator to place between headings in an index.
/// </summary>
public enum WdHeadingSeparator
{
  /// <summary>
  /// No separator.
  /// </summary>
  None = 0,
  /// <summary>
  /// A blank line.
  /// </summary>
  BlankLine = 1,
  /// <summary>
  /// A designated letter.
  /// </summary>
  Letter = 2,
  /// <summary>
  /// A designated lowercase letter.
  /// </summary>
  LetterLow = 3,
  /// <summary>
  /// A designated uppercase letter.
  /// </summary>
  LetterFull = 4
}
