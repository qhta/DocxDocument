namespace DocumentModel.Wordprocessing;

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