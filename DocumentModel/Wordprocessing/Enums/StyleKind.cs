namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StyleKind
{
  /// <summary>
  ///   IParagraph IStyle.
  /// </summary>
  IParagraph,

  /// <summary>
  ///   Character IStyle.
  /// </summary>
  Character,

  /// <summary>
  ///   ITable IStyle.
  /// </summary>
  ITable,

  /// <summary>
  ///   Numbering IStyle.
  /// </summary>
  Numbering
}
