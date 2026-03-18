namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Unit enumeration.
/// Used in types such as AliasHelper, BytePercent, EighthPoints.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum Unit
{
  /// <summary>Character</summary>
  [OpenXmlEnumValue("Character")]
  Character,
  /// <summary>Word</summary>
  [OpenXmlEnumValue("Word")]
  Word,
  /// <summary>Sentence</summary>
  [OpenXmlEnumValue("Sentence")]
  Sentence,
  /// <summary>Paragraph</summary>
  [OpenXmlEnumValue("Paragraph")]
  Paragraph,
  /// <summary>Line</summary>
  [OpenXmlEnumValue("Line")]
  Line,
  /// <summary>Story</summary>
  [OpenXmlEnumValue("Story")]
  Story,
  /// <summary>Screen</summary>
  [OpenXmlEnumValue("Screen")]
  Screen,
  /// <summary>Section</summary>
  [OpenXmlEnumValue("Section")]
  Section,
  /// <summary>Column</summary>
  [OpenXmlEnumValue("Column")]
  Column,
  /// <summary>Row</summary>
  [OpenXmlEnumValue("Row")]
  Row,
  /// <summary>Window</summary>
  [OpenXmlEnumValue("Window")]
  Window,
  /// <summary>Cell</summary>
  [OpenXmlEnumValue("Cell")]
  Cell,
  /// <summary>Character formatting</summary>
  [OpenXmlEnumValue("CharacterFormatting")]
  CharacterFormatting,
  /// <summary>Paragraph formatting</summary>
  [OpenXmlEnumValue("ParagraphFormatting")]
  ParagraphFormatting,
  /// <summary>Table</summary>
  [OpenXmlEnumValue("Table")]
  Table,
  /// <summary>Item</summary>
  [OpenXmlEnumValue("Item")]
  Item
}
