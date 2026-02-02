namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the type of style.
/// </summary>
[OpenXmlNotMapped]
public enum InteropStyleKind
{
  /// <summary>Paragraph style</summary>
  Paragraph = 1,
  /// <summary>Character style</summary>
  Character = 2,
  /// <summary>Table style</summary>
  Table = 3,
  /// <summary>List style</summary>
  List = 4,
  /// <summary>Numbering style</summary>
  Numbering = 5
}