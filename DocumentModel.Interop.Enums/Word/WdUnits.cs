namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
public enum WdUnits
{
  /// <summary>
  /// A character.
  /// </summary>
  Character = unchecked((int)1),
  /// <summary>
  /// A word.
  /// </summary>
  Word = unchecked((int)2),
  /// <summary>
  /// A sentence.
  /// </summary>
  Sentence = unchecked((int)3),
  /// <summary>
  /// A paragraph.
  /// </summary>
  Paragraph = unchecked((int)4),
  /// <summary>
  /// A line.
  /// </summary>
  Line = unchecked((int)5),
  /// <summary>
  /// A story.
  /// </summary>
  Story = unchecked((int)6),
  /// <summary>
  /// The screen dimensions.
  /// </summary>
  Screen = unchecked((int)7),
  /// <summary>
  /// A section.
  /// </summary>
  Section = unchecked((int)8),
  /// <summary>
  /// A column.
  /// </summary>
  Column = unchecked((int)9),
  /// <summary>
  /// A row.
  /// </summary>
  Row = unchecked((int)10),
  /// <summary>
  /// A window. [System.Runtime.InteropServices.Guid("D66B392B-BDA5-3778-A812-F6EEA5A96C2F")] public enum WdUnits ﾉ
  /// Expand table
  /// </summary>
  Window = unchecked((int)11),
  /// <summary>
  /// A cell.
  /// </summary>
  Cell = unchecked((int)12),
  /// <summary>
  /// Character formatting.
  /// </summary>
  CharacterFormatting = unchecked((int)13),
  /// <summary>
  /// Paragraph formatting.
  /// </summary>
  ParagraphFormatting = unchecked((int)14),
  /// <summary>
  /// A table.
  /// </summary>
  Table = unchecked((int)15),
  /// <summary>
  /// The selected item.
  /// </summary>
  Item = unchecked((int)16)
}
