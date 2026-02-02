namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the sort order for bibliography entries.
/// </summary>
[OpenXmlNotMapped]
public enum BibliographySortOrder
{
  /// <summary>Alphabetically by author last name</summary>
  Author,
  /// <summary>Alphabetically by title</summary>
  Title,
  /// <summary>By year of publication (newest first)</summary>
  YearDescending,
  /// <summary>By year of publication (oldest first)</summary>
  YearAscending,
  /// <summary>By order of appearance in document</summary>
  AppearanceOrder,
  /// <summary>By tag identifier</summary>
  Tag,
  /// <summary>Custom sort order</summary>
  Custom
}