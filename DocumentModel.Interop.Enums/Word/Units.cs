namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunits?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdUnits")]
public enum Units
{
  /// <summary>
  /// A character.
  /// </summary>
  [WordInteropEnumValue("wdCharacter")]
  Character = 1,
  /// <summary>
  /// A word.
  /// </summary>
  [WordInteropEnumValue("wdWord")]
  Word = 2,
  /// <summary>
  /// A sentence.
  /// </summary>
  [WordInteropEnumValue("wdSentence")]
  Sentence = 3,
  /// <summary>
  /// A paragraph.
  /// </summary>
  [WordInteropEnumValue("wdParagraph")]
  Paragraph = 4,
  /// <summary>
  /// A line.
  /// </summary>
  [WordInteropEnumValue("wdLine")]
  Line = 5,
  /// <summary>
  /// A story.
  /// </summary>
  [WordInteropEnumValue("wdStory")]
  Story = 6,
  /// <summary>
  /// The screen dimensions.
  /// </summary>
  [WordInteropEnumValue("wdScreen")]
  Screen = 7,
  /// <summary>
  /// A section.
  /// </summary>
  [WordInteropEnumValue("wdSection")]
  Section = 8,
  /// <summary>
  /// A column.
  /// </summary>
  [WordInteropEnumValue("wdColumn")]
  Column = 9,
  /// <summary>
  /// A row.
  /// </summary>
  [WordInteropEnumValue("wdRow")]
  Row = 10,
  /// <summary>
  /// A window.
  /// </summary>
  [WordInteropEnumValue("wdWindow")]
  Window = 11,
  /// <summary>
  /// A cell.
  /// </summary>
  [WordInteropEnumValue("wdCell")]
  Cell = 12,
  /// <summary>
  /// Character formatting.
  /// </summary>
  [WordInteropEnumValue("wdCharacterFormatting")]
  CharacterFormatting = 13,
  /// <summary>
  /// Paragraph formatting.
  /// </summary>
  [WordInteropEnumValue("wdParagraphFormatting")]
  ParagraphFormatting = 14,
  /// <summary>
  /// A table.
  /// </summary>
  [WordInteropEnumValue("wdTable")]
  Table = 15,
  /// <summary>
  /// The selected item.
  /// </summary>
  [WordInteropEnumValue("wdItem")]
  Item = 16
}
