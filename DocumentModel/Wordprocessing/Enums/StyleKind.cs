namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StyleKind
{
  /// <summary>
  ///   Paragraph Style.
  /// </summary>
  Paragraph,

  /// <summary>
  ///   Character Style.
  /// </summary>
  Character,

  /// <summary>
  ///   Table Style.
  /// </summary>
  Table,

  /// <summary>
  ///   Numbering Style.
  /// </summary>
  Numbering
}