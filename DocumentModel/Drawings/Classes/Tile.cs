namespace DocumentModel.Drawings;

/// <summary>
///   Tile.
/// </summary>
public class Tile: ModelElement
{
  /// <summary>
  ///   Horizontal Offset
  /// </summary>
  public Int64? HorizontalOffset { get; set; }

  /// <summary>
  ///   Vertical Offset
  /// </summary>
  public Int64? VerticalOffset { get; set; }

  /// <summary>
  ///   Horizontal Ratio
  /// </summary>
  public Int32? HorizontalRatio { get; set; }

  /// <summary>
  ///   Vertical Ratio
  /// </summary>
  public Int32? VerticalRatio { get; set; }

  /// <summary>
  ///   Tile Flipping
  /// </summary>
  public TileFlipKind? Flip { get; set; }

  /// <summary>
  ///   Alignment
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }
}