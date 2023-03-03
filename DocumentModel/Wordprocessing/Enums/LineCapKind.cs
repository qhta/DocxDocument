namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the LineCapValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineCapKind
{
  /// <summary>
  ///   rnd.
  /// </summary>
  Round,

  /// <summary>
  ///   sq.
  /// </summary>
  Square,

  /// <summary>
  ///   flat.
  /// </summary>
  Flat
}