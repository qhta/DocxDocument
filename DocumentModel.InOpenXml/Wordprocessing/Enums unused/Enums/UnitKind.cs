namespace DocumentModel.Wordprocessing;

/// <summary>
/// Unit types for range operations.
/// </summary>
[OpenXmlNotMapped]
public enum UnitKind
{
  /// <summary>Character</summary>
  Character,
  /// <summary>Word</summary>
  Word,
  /// <summary>Sentence</summary>
  Sentence,
  /// <summary>Paragraph</summary>
  Paragraph,
  /// <summary>Line</summary>
  Line,
  /// <summary>Story</summary>
  Story,
  /// <summary>Screen</summary>
  Screen,
  /// <summary>Section</summary>
  Section,
  /// <summary>Column</summary>
  Column,
  /// <summary>Row</summary>
  Row,
  /// <summary>Window</summary>
  Window,
  /// <summary>Cell</summary>
  Cell,
  /// <summary>Character formatting</summary>
  CharacterFormatting,
  /// <summary>Paragraph formatting</summary>
  ParagraphFormatting,
  /// <summary>Table</summary>
  Table,
  /// <summary>Item</summary>
  Item
}