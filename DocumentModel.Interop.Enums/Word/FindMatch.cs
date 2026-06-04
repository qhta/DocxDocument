namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfindmatch?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdFindMatch")]
public enum FindMatch
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchGraphic")]
  Graphic = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchCommentMark")]
  CommentMark = 5,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchTabCharacter")]
  TabCharacter = 9,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchCaretCharacter")]
  CaretCharacter = 11,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchColumnBreak")]
  ColumnBreak = 14,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchField")]
  Field = 19,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchNonbreakingHyphen")]
  NonbreakingHyphen = 30,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchOptionalHyphen")]
  OptionalHyphen = 31,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchNonbreakingSpace")]
  NonbreakingSpace = 160,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchEnDash")]
  EnDash = 8211,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchEmDash")]
  EmDash = 8212,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchManualLineBreak")]
  ManualLineBreak = 65551,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchParagraphMark")]
  ParagraphMark = 65551,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchFootnoteMark")]
  FootnoteMark = 65554,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchEndnoteMark")]
  EndnoteMark = 65555,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchManualPageBreak")]
  ManualPageBreak = 65564,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchAnyDigit")]
  AnyDigit = 65567,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchSectionBreak")]
  SectionBreak = 65580,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchAnyLetter")]
  AnyLetter = 65583,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchAnyCharacter")]
  AnyCharacter = 65599,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdMatchWhiteSpace")]
  WhiteSpace = 65655
}
