namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfindmatch?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdFindMatch")]
public enum FindMatch
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchGraphic")]
  Graphic = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchCommentMark")]
  CommentMark = 5,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchTabCharacter")]
  TabCharacter = 9,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchCaretCharacter")]
  CaretCharacter = 11,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchColumnBreak")]
  ColumnBreak = 14,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchField")]
  Field = 19,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchNonbreakingHyphen")]
  NonbreakingHyphen = 30,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchOptionalHyphen")]
  OptionalHyphen = 31,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchNonbreakingSpace")]
  NonbreakingSpace = 160,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchEnDash")]
  EnDash = 8211,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchEmDash")]
  EmDash = 8212,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchManualLineBreak")]
  ManualLineBreak = 65551,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchParagraphMark")]
  ParagraphMark = 65551,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchFootnoteMark")]
  FootnoteMark = 65554,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchEndnoteMark")]
  EndnoteMark = 65555,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchManualPageBreak")]
  ManualPageBreak = 65564,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchAnyDigit")]
  AnyDigit = 65567,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchSectionBreak")]
  SectionBreak = 65580,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchAnyLetter")]
  AnyLetter = 65583,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchAnyCharacter")]
  AnyCharacter = 65599,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdMatchWhiteSpace")]
  WhiteSpace = 65655
}
