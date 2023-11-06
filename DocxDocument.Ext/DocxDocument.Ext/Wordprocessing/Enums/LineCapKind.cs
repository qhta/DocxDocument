namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineCapValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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