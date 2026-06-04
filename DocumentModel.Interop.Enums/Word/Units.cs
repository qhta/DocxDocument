namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunits?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdUnits")]
public enum Units
{
  /// <summary>
  /// A character.
  /// </summary>
  [InteropEnumValue("wdCharacter")]
  Character = 1,
  /// <summary>
  /// A word.
  /// </summary>
  [InteropEnumValue("wdWord")]
  Word = 2,
  /// <summary>
  /// A sentence.
  /// </summary>
  [InteropEnumValue("wdSentence")]
  Sentence = 3,
  /// <summary>
  /// A paragraph.
  /// </summary>
  [InteropEnumValue("wdParagraph")]
  Paragraph = 4,
  /// <summary>
  /// A line.
  /// </summary>
  [InteropEnumValue("wdLine")]
  Line = 5,
  /// <summary>
  /// A story.
  /// </summary>
  [InteropEnumValue("wdStory")]
  Story = 6,
  /// <summary>
  /// The screen dimensions.
  /// </summary>
  [InteropEnumValue("wdScreen")]
  Screen = 7,
  /// <summary>
  /// A section.
  /// </summary>
  [InteropEnumValue("wdSection")]
  Section = 8,
  /// <summary>
  /// A column.
  /// </summary>
  [InteropEnumValue("wdColumn")]
  Column = 9,
  /// <summary>
  /// A row.
  /// </summary>
  [InteropEnumValue("wdRow")]
  Row = 10,
  /// <summary>
  /// A window.
  /// </summary>
  [InteropEnumValue("wdWindow")]
  Window = 11,
  /// <summary>
  /// A cell.
  /// </summary>
  [InteropEnumValue("wdCell")]
  Cell = 12,
  /// <summary>
  /// Character formatting.
  /// </summary>
  [InteropEnumValue("wdCharacterFormatting")]
  CharacterFormatting = 13,
  /// <summary>
  /// Paragraph formatting.
  /// </summary>
  [InteropEnumValue("wdParagraphFormatting")]
  ParagraphFormatting = 14,
  /// <summary>
  /// A table.
  /// </summary>
  [InteropEnumValue("wdTable")]
  Table = 15,
  /// <summary>
  /// The selected item.
  /// </summary>
  [InteropEnumValue("wdItem")]
  Item = 16
}
