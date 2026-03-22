namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a unit of measure to use.
/// </summary>
public enum WdUnits
{
  /// <summary>
  /// A character.
  /// </summary>
  wdCharacter = unchecked((int)1),
  /// <summary>
  /// A word.
  /// </summary>
  wdWord = unchecked((int)2),
  /// <summary>
  /// A sentence.
  /// </summary>
  wdSentence = unchecked((int)3),
  /// <summary>
  /// A paragraph.
  /// </summary>
  wdParagraph = unchecked((int)4),
  /// <summary>
  /// A line.
  /// </summary>
  wdLine = unchecked((int)5),
  /// <summary>
  /// A story.
  /// </summary>
  wdStory = unchecked((int)6),
  /// <summary>
  /// The screen dimensions.
  /// </summary>
  wdScreen = unchecked((int)7),
  /// <summary>
  /// A section.
  /// </summary>
  wdSection = unchecked((int)8),
  /// <summary>
  /// A column.
  /// </summary>
  wdColumn = unchecked((int)9),
  /// <summary>
  /// A row.
  /// </summary>
  wdRow = unchecked((int)10),
  /// <summary>
  /// A window. [System.Runtime.InteropServices.Guid("D66B392B-BDA5-3778-A812-F6EEA5A96C2F")] public enum WdUnits ﾉ
  /// Expand table
  /// </summary>
  wdWindow = unchecked((int)11),
  /// <summary>
  /// A cell.
  /// </summary>
  wdCell = unchecked((int)12),
  /// <summary>
  /// Character formatting.
  /// </summary>
  wdCharacterFormatting = unchecked((int)13),
  /// <summary>
  /// Paragraph formatting.
  /// </summary>
  wdParagraphFormatting = unchecked((int)14),
  /// <summary>
  /// A table.
  /// </summary>
  wdTable = unchecked((int)15),
  /// <summary>
  /// The selected item.
  /// </summary>
  wdItem = unchecked((int)16)
}
