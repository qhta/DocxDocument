namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of text separator to place between headings in an index.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdheadingseparator?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdHeadingSeparator")]
public enum HeadingSeparator
{
  /// <summary>
  /// No separator.
  /// </summary>
  [InteropEnumValue("wdHeadingSeparatorNone")]
  None = 0,
  /// <summary>
  /// A blank line.
  /// </summary>
  [InteropEnumValue("wdHeadingSeparatorBlankLine")]
  BlankLine = 1,
  /// <summary>
  /// A designated letter.
  /// </summary>
  [InteropEnumValue("wdHeadingSeparatorLetter")]
  Letter = 2,
  /// <summary>
  /// A designated lowercase letter.
  /// </summary>
  [InteropEnumValue("wdHeadingSeparatorLetterLow")]
  LetterLow = 3,
  /// <summary>
  /// A designated uppercase letter.
  /// </summary>
  [InteropEnumValue("wdHeadingSeparatorLetterFull")]
  LetterFull = 4
}
