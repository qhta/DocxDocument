namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the OnOffValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OnOffKind
{
  /// <summary>
  ///   true.
  /// </summary>
  True,

  /// <summary>
  ///   false.
  /// </summary>
  False,

  /// <summary>
  ///   0.
  /// </summary>
  Zero,

  /// <summary>
  ///   1.
  /// </summary>
  One
}
