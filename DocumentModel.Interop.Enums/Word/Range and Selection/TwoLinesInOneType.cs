namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use to enclose two lines being written into one.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdtwolinesinonetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTwoLinesInOneType")]
public enum TwoLinesInOneType
{
  /// <summary>
  /// Restore the two lines of text written into one to two separate lines.
  /// </summary>
  [InteropEnumValue("wdTwoLinesInOneNone")]
  None = 0,
  /// <summary>
  /// Use no enclosing character.
  /// </summary>
  [InteropEnumValue("wdTwoLinesInOneNoBrackets")]
  NoBrackets = 1,
  /// <summary>
  /// Enclose the lines using parentheses.
  /// </summary>
  [InteropEnumValue("wdTwoLinesInOneParentheses")]
  Parentheses = 2,
  /// <summary>
  /// Enclose the lines using square brackets.
  /// </summary>
  [InteropEnumValue("wdTwoLinesInOneSquareBrackets")]
  SquareBrackets = 3,
  /// <summary>
  /// Enclose the lines using angle brackets.
  /// </summary>
  [InteropEnumValue("wdTwoLinesInOneAngleBrackets")]
  AngleBrackets = 4,
  /// <summary>
  /// Enclose the lines using curly brackets.
  /// </summary>
  [InteropEnumValue("wdTwoLinesInOneCurlyBrackets")]
  CurlyBrackets = 5
}
