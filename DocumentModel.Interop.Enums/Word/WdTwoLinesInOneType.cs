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
  wdTwoLinesInOneNone = unchecked((int)0),
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  wdTwoLinesInOneNoBrackets = unchecked((int)1),
  /// <summary>
  /// Enclose the lines using parentheses. wdTwoLinesInOneSquareBrackets3 Enclose the lines using square brackets.
  /// wdTwoLinesInOneAngleBrackets4 Enclose the lines using angle brackets. wdTwoLinesInOneCurlyBrackets5 Enclose
  /// the lines using curly brackets.
  /// </summary>
  wdTwoLinesInOneParentheses = unchecked((int)2),
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  wdTwoLinesInOneSquareBrackets = unchecked((int)3),
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  wdTwoLinesInOneAngleBrackets = unchecked((int)4),
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  wdTwoLinesInOneCurlyBrackets = unchecked((int)5)
}
