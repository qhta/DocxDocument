namespace DocumentModel.Drawings;

/// <summary>
/// Tile.
/// </summary>
public class Tile
{
  /// <summary>
  /// Tile Flipping
  /// </summary>
  public TileFlipKind? Flip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public RectangleAlignmentKind? Alignment
  {
    get;
    set;
  }
  
}
