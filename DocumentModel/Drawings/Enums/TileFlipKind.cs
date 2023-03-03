namespace DocumentModel.Drawings;

/// <summary>
///   Tile Flip Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TileFlipKind
{
  /// <summary>
  ///   None.
  /// </summary>
  None,

  /// <summary>
  ///   Horizontal.
  /// </summary>
  Horizontal,

  /// <summary>
  ///   Vertical.
  /// </summary>
  Vertical,

  /// <summary>
  ///   Horizontal and Vertical.
  /// </summary>
  HorizontalAndVertical
}