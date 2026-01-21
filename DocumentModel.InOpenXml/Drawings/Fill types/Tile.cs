namespace DocumentModel.Drawings;
/// <summary>
///   Represents tiling options for a fill, including offset, scaling, flipping, and alignment.
/// </summary>
public partial class Tile : ModelElement
{
  /// <summary>
  ///   Horizontal offset for the tile.
  /// </summary>
  public Int64? HorizontalOffset { get; set; }
  /// <summary>
  ///   Vertical offset for the tile.
  /// </summary>
  public Int64? VerticalOffset { get; set; }
  /// <summary>
  ///   Horizontal scaling ratio for the tile.
  /// </summary>
  public Int32? HorizontalRatio { get; set; }
  /// <summary>
  ///   Vertical scaling ratio for the tile.
  /// </summary>
  public Int32? VerticalRatio { get; set; }
  /// <summary>
  ///   Tile flipping mode.
  /// </summary>
  public TileFlipKind? Flip { get; set; }
  /// <summary>
  ///   Alignment of the tile within the filled area.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }
}