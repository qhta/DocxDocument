namespace DocumentModel.Drawings;

/// <summary>
/// Tile.
/// </summary>
public interface Tile
{
  /// <summary>
  /// Tile Flipping
  /// </summary>
  public TileFlipKind? Flip { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public RectangleAlignmentKind? Alignment { get ; set; }
  
}
