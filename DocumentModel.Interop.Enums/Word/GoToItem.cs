namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to move the insertion point or selection just prior to.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgotoitem?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdGoToItem")]
public enum GoToItem
{
  /// <summary>
  /// A section.
  /// </summary>
  [InteropEnumValue("wdGoToSection")]
  Section = 0,
  /// <summary>
  /// A page.
  /// </summary>
  [InteropEnumValue("wdGoToPage")]
  Page = 1,
  /// <summary>
  /// A table.
  /// </summary>
  [InteropEnumValue("wdGoToTable")]
  Table = 2,
  /// <summary>
  /// A line.
  /// </summary>
  [InteropEnumValue("wdGoToLine")]
  Line = 3,
  /// <summary>
  /// A footnote.
  /// </summary>
  [InteropEnumValue("wdGoToFootnote")]
  Footnote = 4,
  /// <summary>
  /// An endnote.
  /// </summary>
  [InteropEnumValue("wdGoToEndnote")]
  Endnote = 5,
  /// <summary>
  /// A comment.
  /// </summary>
  [InteropEnumValue("wdGoToComment")]
  Comment = 6,
  /// <summary>
  /// A field.
  /// </summary>
  [InteropEnumValue("wdGoToField")]
  Field = 7,
  /// <summary>
  /// A graphic.
  /// </summary>
  [InteropEnumValue("wdGoToGraphic")]
  Graphic = 8,
  /// <summary>
  /// An object.
  /// </summary>
  [InteropEnumValue("wdGoToObject")]
  Object = 9,
  /// <summary>
  /// An equation.
  /// </summary>
  [InteropEnumValue("wdGoToEquation")]
  Equation = 10,
  /// <summary>
  /// A heading.
  /// </summary>
  [InteropEnumValue("wdGoToHeading")]
  Heading = 11,
  /// <summary>
  /// A percent.
  /// </summary>
  [InteropEnumValue("wdGoToPercent")]
  Percent = 12,
  /// <summary>
  /// A spelling error.
  /// </summary>
  [InteropEnumValue("wdGoToSpellingError")]
  SpellingError = 13,
  /// <summary>
  /// A grammatical error.
  /// </summary>
  [InteropEnumValue("wdGoToGrammaticalError")]
  GrammaticalError = 14,
  /// <summary>
  /// A proofreading error.
  /// </summary>
  [InteropEnumValue("wdGoToProofreadingError")]
  ProofreadingError = 15,
  /// <summary>
  /// A bookmark.
  /// </summary>
  [InteropEnumValue("wdGoToBookmark")]
  Bookmark = -1
}
