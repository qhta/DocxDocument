namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to move the insertion point or selection just prior to.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgotoitem?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdGoToItem))]
public enum GoToItem
{
  /// <summary>
  /// A section.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToSection))]
  Section = 0,
  /// <summary>
  /// A page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToPage))]
  Page = 1,
  /// <summary>
  /// A table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToTable))]
  Table = 2,
  /// <summary>
  /// A line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToLine))]
  Line = 3,
  /// <summary>
  /// A footnote.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToFootnote))]
  Footnote = 4,
  /// <summary>
  /// An endnote.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToEndnote))]
  Endnote = 5,
  /// <summary>
  /// A comment.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToComment))]
  Comment = 6,
  /// <summary>
  /// A field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToField))]
  Field = 7,
  /// <summary>
  /// A graphic.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToGraphic))]
  Graphic = 8,
  /// <summary>
  /// An object.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToObject))]
  Object = 9,
  /// <summary>
  /// An equation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToEquation))]
  Equation = 10,
  /// <summary>
  /// A heading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToHeading))]
  Heading = 11,
  /// <summary>
  /// A percent.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToPercent))]
  Percent = 12,
  /// <summary>
  /// A spelling error.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToSpellingError))]
  SpellingError = 13,
  /// <summary>
  /// A grammatical error.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToGrammaticalError))]
  GrammaticalError = 14,
  /// <summary>
  /// A proofreading error.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToProofreadingError))]
  ProofreadingError = 15,
  /// <summary>
  /// A bookmark.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark))]
  Bookmark = -1
}
