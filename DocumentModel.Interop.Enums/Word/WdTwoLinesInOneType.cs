namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use to enclose two lines being written into one.
/// </summary>
public enum WdTwoLinesInOneType
{
  /// <summary>
  /// Restore the two lines of text written into one to two separate lines. wdTwoLinesInOneNoBrackets1 Use no
  /// enclosing character.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  NoBrackets = unchecked((int)1),
  /// <summary>
  /// Enclose the lines using parentheses. wdTwoLinesInOneSquareBrackets3 Enclose the lines using square brackets.
  /// wdTwoLinesInOneAngleBrackets4 Enclose the lines using angle brackets. wdTwoLinesInOneCurlyBrackets5 Enclose
  /// the lines using curly brackets.
  /// </summary>
  Parentheses = unchecked((int)2),
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  SquareBrackets = unchecked((int)3),
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  AngleBrackets = unchecked((int)4),
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  CurlyBrackets = unchecked((int)5)
}
