namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the InfoTextValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum InfoTextKind
{
  /// <summary>
  ///   Literal Text.
  /// </summary>
  Text,
  /// <summary>
  ///   Glossary Document Entry.
  /// </summary>
  AutoText
}