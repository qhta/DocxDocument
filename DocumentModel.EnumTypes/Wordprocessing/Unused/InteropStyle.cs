namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the InteropStyle enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum InteropStyle
{
  /// <summary>Paragraph style</summary>
  [OpenXmlEnumValue("Paragraph")]
  Paragraph = 1,
  /// <summary>Character style</summary>
  [OpenXmlEnumValue("Character")]
  Character = 2,
  /// <summary>Table style</summary>
  [OpenXmlEnumValue("Table")]
  Table = 3,
  /// <summary>List style</summary>
  [OpenXmlEnumValue("List")]
  List = 4,
  /// <summary>Numbering style</summary>
  [OpenXmlEnumValue("Numbering")]
  Numbering = 5
}
