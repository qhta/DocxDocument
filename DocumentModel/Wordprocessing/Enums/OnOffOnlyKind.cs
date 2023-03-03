namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the OnOffOnlyValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OnOffOnlyKind
{
  /// <summary>
  ///   on.
  /// </summary>
  On,

  /// <summary>
  ///   off.
  /// </summary>
  Off
}