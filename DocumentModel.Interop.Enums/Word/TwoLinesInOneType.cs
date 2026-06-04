namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use to enclose two lines being written into one.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdtwolinesinonetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTwoLinesInOneType))]
public enum TwoLinesInOneType
{
  /// <summary>
  /// Restore the two lines of text written into one to two separate lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTwoLinesInOneType.wdTwoLinesInOneNone))]
  None = 0,
  /// <summary>
  /// Use no enclosing character.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTwoLinesInOneType.wdTwoLinesInOneNoBrackets))]
  NoBrackets = 1,
  /// <summary>
  /// Enclose the lines using parentheses.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTwoLinesInOneType.wdTwoLinesInOneParentheses))]
  Parentheses = 2,
  /// <summary>
  /// Enclose the lines using square brackets.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTwoLinesInOneType.wdTwoLinesInOneSquareBrackets))]
  SquareBrackets = 3,
  /// <summary>
  /// Enclose the lines using angle brackets.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTwoLinesInOneType.wdTwoLinesInOneAngleBrackets))]
  AngleBrackets = 4,
  /// <summary>
  /// Enclose the lines using curly brackets.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTwoLinesInOneType.wdTwoLinesInOneCurlyBrackets))]
  CurlyBrackets = 5
}
