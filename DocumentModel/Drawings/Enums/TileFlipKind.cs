namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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