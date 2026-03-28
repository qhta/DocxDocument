namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the trailing character that follows list numbering.
/// </summary>
[OpenXmlNotMapped]
public enum TrailingCharacterKind
{
  /// <summary>Tab character</summary>
  Tab = 0,
  /// <summary>Space character</summary>
  Space = 1,
  /// <summary>No trailing character</summary>
  Nothing = 2
}