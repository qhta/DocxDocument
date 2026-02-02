namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the criteria for sorting sources.
/// </summary>
[OpenXmlNotMapped]
public enum SourceSortKind
{
  /// <summary>Sort by tag identifier</summary>
  Tag,
  /// <summary>Sort by title</summary>
  Title,
  /// <summary>Sort by author</summary>
  Author,
  /// <summary>Sort by year</summary>
  Year,
  /// <summary>Sort by source type</summary>
  SourceType,
  /// <summary>Sort by date added</summary>
  DateAdded,
  /// <summary>Sort by date modified</summary>
  DateModified
}