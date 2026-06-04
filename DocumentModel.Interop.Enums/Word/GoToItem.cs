namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to move the insertion point or selection just prior to.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgotoitem?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdGoToItem")]
public enum GoToItem
{
  /// <summary>
  /// A section.
  /// </summary>
  [WordInteropEnumValue("wdGoToSection")]
  Section = 0,
  /// <summary>
  /// A page.
  /// </summary>
  [WordInteropEnumValue("wdGoToPage")]
  Page = 1,
  /// <summary>
  /// A table.
  /// </summary>
  [WordInteropEnumValue("wdGoToTable")]
  Table = 2,
  /// <summary>
  /// A line.
  /// </summary>
  [WordInteropEnumValue("wdGoToLine")]
  Line = 3,
  /// <summary>
  /// A footnote.
  /// </summary>
  [WordInteropEnumValue("wdGoToFootnote")]
  Footnote = 4,
  /// <summary>
  /// An endnote.
  /// </summary>
  [WordInteropEnumValue("wdGoToEndnote")]
  Endnote = 5,
  /// <summary>
  /// A comment.
  /// </summary>
  [WordInteropEnumValue("wdGoToComment")]
  Comment = 6,
  /// <summary>
  /// A field.
  /// </summary>
  [WordInteropEnumValue("wdGoToField")]
  Field = 7,
  /// <summary>
  /// A graphic.
  /// </summary>
  [WordInteropEnumValue("wdGoToGraphic")]
  Graphic = 8,
  /// <summary>
  /// An object.
  /// </summary>
  [WordInteropEnumValue("wdGoToObject")]
  Object = 9,
  /// <summary>
  /// An equation.
  /// </summary>
  [WordInteropEnumValue("wdGoToEquation")]
  Equation = 10,
  /// <summary>
  /// A heading.
  /// </summary>
  [WordInteropEnumValue("wdGoToHeading")]
  Heading = 11,
  /// <summary>
  /// A percent.
  /// </summary>
  [WordInteropEnumValue("wdGoToPercent")]
  Percent = 12,
  /// <summary>
  /// A spelling error.
  /// </summary>
  [WordInteropEnumValue("wdGoToSpellingError")]
  SpellingError = 13,
  /// <summary>
  /// A grammatical error.
  /// </summary>
  [WordInteropEnumValue("wdGoToGrammaticalError")]
  GrammaticalError = 14,
  /// <summary>
  /// A proofreading error.
  /// </summary>
  [WordInteropEnumValue("wdGoToProofreadingError")]
  ProofreadingError = 15,
  /// <summary>
  /// A bookmark.
  /// </summary>
  [WordInteropEnumValue("wdGoToBookmark")]
  Bookmark = -1
}
