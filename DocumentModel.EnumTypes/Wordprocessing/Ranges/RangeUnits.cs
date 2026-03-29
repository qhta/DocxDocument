namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunits?view=office-pia` for Office interop details.
/// </remarks>
public enum RangeUnits
{
  /// <summary>
  /// A character.
  /// </summary>
  Character = 1,
  /// <summary>
  /// A word.
  /// </summary>
  Word = 2,
  /// <summary>
  /// A sentence.
  /// </summary>
  Sentence = 3,
  /// <summary>
  /// A paragraph.
  /// </summary>
  Paragraph = 4,
  /// <summary>
  /// A line.
  /// </summary>
  Line = 5,
  /// <summary>
  /// A story.
  /// </summary>
  Story = 6,
  /// <summary>
  /// The screen dimensions.
  /// </summary>
  Screen = 7,
  /// <summary>
  /// A section.
  /// </summary>
  Section = 8,
  /// <summary>
  /// A column.
  /// </summary>
  Column = 9,
  /// <summary>
  /// A row.
  /// </summary>
  Row = 10,
  /// <summary>
  /// A window.
  /// </summary>
  Window = 11,
  /// <summary>
  /// A cell.
  /// </summary>
  Cell = 12,
  /// <summary>
  /// Character formatting.
  /// </summary>
  CharacterFormatting = 13,
  /// <summary>
  /// Paragraph formatting.
  /// </summary>
  ParagraphFormatting = 14,
  /// <summary>
  /// A table.
  /// </summary>
  Table = 15,
  /// <summary>
  /// The selected item.
  /// </summary>
  Item = 16
}
