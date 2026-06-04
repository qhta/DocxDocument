namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of text separator to place between headings in an index.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdheadingseparator?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdHeadingSeparator))]
public enum HeadingSeparator
{
  /// <summary>
  /// No separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHeadingSeparator.wdHeadingSeparatorNone))]
  None = 0,
  /// <summary>
  /// A blank line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHeadingSeparator.wdHeadingSeparatorBlankLine))]
  BlankLine = 1,
  /// <summary>
  /// A designated letter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHeadingSeparator.wdHeadingSeparatorLetter))]
  Letter = 2,
  /// <summary>
  /// A designated lowercase letter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHeadingSeparator.wdHeadingSeparatorLetterLow))]
  LetterLow = 3,
  /// <summary>
  /// A designated uppercase letter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHeadingSeparator.wdHeadingSeparatorLetterFull))]
  LetterFull = 4
}
