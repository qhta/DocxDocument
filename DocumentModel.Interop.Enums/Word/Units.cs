namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunits?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdUnits))]
public enum Units
{
  /// <summary>
  /// A character.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdCharacter))]
  Character = 1,
  /// <summary>
  /// A word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdWord))]
  Word = 2,
  /// <summary>
  /// A sentence.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdSentence))]
  Sentence = 3,
  /// <summary>
  /// A paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdParagraph))]
  Paragraph = 4,
  /// <summary>
  /// A line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdLine))]
  Line = 5,
  /// <summary>
  /// A story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdStory))]
  Story = 6,
  /// <summary>
  /// The screen dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdScreen))]
  Screen = 7,
  /// <summary>
  /// A section.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdSection))]
  Section = 8,
  /// <summary>
  /// A column.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdColumn))]
  Column = 9,
  /// <summary>
  /// A row.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdRow))]
  Row = 10,
  /// <summary>
  /// A window.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdWindow))]
  Window = 11,
  /// <summary>
  /// A cell.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdCell))]
  Cell = 12,
  /// <summary>
  /// Character formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdCharacterFormatting))]
  CharacterFormatting = 13,
  /// <summary>
  /// Paragraph formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdParagraphFormatting))]
  ParagraphFormatting = 14,
  /// <summary>
  /// A table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdTable))]
  Table = 15,
  /// <summary>
  /// The selected item.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnits.wdItem))]
  Item = 16
}
