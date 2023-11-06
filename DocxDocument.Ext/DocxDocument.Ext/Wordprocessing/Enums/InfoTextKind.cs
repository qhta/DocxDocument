namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the InfoTextValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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