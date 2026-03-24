namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use to enclose two lines being written into one.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdtwolinesinonetype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdTwoLinesInOneType
{
  /// <summary>
  /// Restore the two lines of text written into one to two separate lines.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  NoBrackets = 1,
  /// <summary>
  /// Enclose the lines using parentheses.
  /// </summary>
  Parentheses = 2,
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  SquareBrackets = 3,
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  AngleBrackets = 4,
  /// <summary>
  /// Specifies the character to use to enclose two lines being written into one.
  /// </summary>
  CurlyBrackets = 5
}
