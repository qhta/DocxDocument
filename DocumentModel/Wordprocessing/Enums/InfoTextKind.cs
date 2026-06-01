namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  ///   Glossary IDocument Entry.
  /// </summary>
  AutoText
}
