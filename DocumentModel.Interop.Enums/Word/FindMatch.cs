namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfindmatch?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFindMatch))]
public enum FindMatch
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchGraphic))]
  Graphic = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchCommentMark))]
  CommentMark = 5,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchTabCharacter))]
  TabCharacter = 9,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchCaretCharacter))]
  CaretCharacter = 11,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchColumnBreak))]
  ColumnBreak = 14,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchField))]
  Field = 19,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchNonbreakingHyphen))]
  NonbreakingHyphen = 30,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchOptionalHyphen))]
  OptionalHyphen = 31,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchNonbreakingSpace))]
  NonbreakingSpace = 160,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchEnDash))]
  EnDash = 8211,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchEmDash))]
  EmDash = 8212,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchManualLineBreak))]
  ManualLineBreak = 65551,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchParagraphMark))]
  ParagraphMark = 65551,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchFootnoteMark))]
  FootnoteMark = 65554,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchEndnoteMark))]
  EndnoteMark = 65555,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchManualPageBreak))]
  ManualPageBreak = 65564,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchAnyDigit))]
  AnyDigit = 65567,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchSectionBreak))]
  SectionBreak = 65580,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchAnyLetter))]
  AnyLetter = 65583,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchAnyCharacter))]
  AnyCharacter = 65599,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindMatch.wdMatchWhiteSpace))]
  WhiteSpace = 65655
}
