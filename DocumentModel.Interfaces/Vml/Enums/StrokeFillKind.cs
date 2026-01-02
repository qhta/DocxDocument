namespace DocumentModel.Vml;

/// <summary>
///   Defines the StrokeFillTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeFillKind
{
  /// <summary>
  ///   solid.
  /// </summary>
  Solid,
  /// <summary>
  ///   tile.
  /// </summary>
  Tile,
  /// <summary>
  ///   pattern.
  /// </summary>
  Pattern,
  /// <summary>
  ///   frame.
  /// </summary>
  Frame
}