namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Statistic enumeration.
/// Used in types such as AllDocumentProperties, DocumentProperties, PropertiesAndSettings.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum Statistic
{
  /// <summary>Character count</summary>
  [OpenXmlEnumValue("Characters")]
  Characters,
  /// <summary>Character count with spaces</summary>
  [OpenXmlEnumValue("CharactersWithSpaces")]
  CharactersWithSpaces,
  /// <summary>Word count</summary>
  [OpenXmlEnumValue("Words")]
  Words,
  /// <summary>Paragraph count</summary>
  [OpenXmlEnumValue("Paragraphs")]
  Paragraphs,
  /// <summary>Line count</summary>
  [OpenXmlEnumValue("Lines")]
  Lines,
  /// <summary>Page count</summary>
  [OpenXmlEnumValue("Pages")]
  Pages,
  /// <summary>Far East character count</summary>
  [OpenXmlEnumValue("FarEastCharacters")]
  FarEastCharacters
}
