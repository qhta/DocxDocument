namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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