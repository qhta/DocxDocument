namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of text separator to place between headings in an index.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdheadingseparator?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdHeadingSeparator")]
public enum HeadingSeparator
{
  /// <summary>
  /// No separator.
  /// </summary>
  [WordInteropEnumValue("wdHeadingSeparatorNone")]
  None = 0,
  /// <summary>
  /// A blank line.
  /// </summary>
  [WordInteropEnumValue("wdHeadingSeparatorBlankLine")]
  BlankLine = 1,
  /// <summary>
  /// A designated letter.
  /// </summary>
  [WordInteropEnumValue("wdHeadingSeparatorLetter")]
  Letter = 2,
  /// <summary>
  /// A designated lowercase letter.
  /// </summary>
  [WordInteropEnumValue("wdHeadingSeparatorLetterLow")]
  LetterLow = 3,
  /// <summary>
  /// A designated uppercase letter.
  /// </summary>
  [WordInteropEnumValue("wdHeadingSeparatorLetterFull")]
  LetterFull = 4
}
