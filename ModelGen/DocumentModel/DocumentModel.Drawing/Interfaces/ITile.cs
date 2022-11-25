namespace DocumentModel.Drawing;

/// <summary>
/// Tile.
/// </summary>
public interface ITile // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  public System.Int64? HorizontalOffset { get ; set; }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  public System.Int64? VerticalOffset { get ; set; }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public System.Int32? HorizontalRatio { get ; set; }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public System.Int32? VerticalRatio { get ; set; }
  
  /// <summary>
  /// Tile Flipping
  /// </summary>
  public DocumentModel.Drawing.TileFlipKind? Flip { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public DocumentModel.Drawing.RectangleAlignmentKind? Alignment { get ; set; }
  
}
