namespace DocumentModel.Wordprocessing;

/// <summary>
/// Statistics types.
/// </summary>
[OpenXmlNotMapped]
public enum StatisticKind
{
  /// <summary>Character count</summary>
  Characters,
  /// <summary>Character count with spaces</summary>
  CharactersWithSpaces,
  /// <summary>Word count</summary>
  Words,
  /// <summary>Paragraph count</summary>
  Paragraphs,
  /// <summary>Line count</summary>
  Lines,
  /// <summary>Page count</summary>
  Pages,
  /// <summary>Far East character count</summary>
  FarEastCharacters
}