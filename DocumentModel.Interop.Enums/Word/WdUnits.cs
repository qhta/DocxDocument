namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunits?view=office-pia` for Office interop details.
/// </remarks>
public enum WdUnits
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
  /// Specifies a unit of measure to use.
  /// </summary>
  Cell = 12,
  /// <summary>
  /// Specifies a unit of measure to use.
  /// </summary>
  CharacterFormatting = 13,
  /// <summary>
  /// Specifies a unit of measure to use.
  /// </summary>
  ParagraphFormatting = 14,
  /// <summary>
  /// Specifies a unit of measure to use.
  /// </summary>
  Table = 15,
  /// <summary>
  /// Specifies a unit of measure to use.
  /// </summary>
  Item = 16
}
