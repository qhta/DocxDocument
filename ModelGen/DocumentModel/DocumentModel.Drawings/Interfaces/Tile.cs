namespace DocumentModel.Drawings;

/// <summary>
/// Tile.
/// </summary>
public partial interface Tile
{
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  public Int64? HorizontalOffset { get; set; }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  public Int64? VerticalOffset { get; set; }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public Int32? HorizontalRatio { get; set; }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public Int32? VerticalRatio { get; set; }
  
  /// <summary>
  /// Tile Flipping
  /// </summary>
  public DocumentModel.Drawings.TileFlipKind? Flip { get; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public DocumentModel.Drawings.RectangleAlignmentKind? Alignment { get; set; }
  
}
