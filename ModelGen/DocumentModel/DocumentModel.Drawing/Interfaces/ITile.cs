namespace DocumentModel.Drawing;

/// <summary>
/// Tile.
/// </summary>
public interface ITile // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  public long? HorizontalOffset { get ; set; }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  public long? VerticalOffset { get ; set; }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public int? HorizontalRatio { get ; set; }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public int? VerticalRatio { get ; set; }
  
  /// <summary>
  /// Tile Flipping
  /// </summary>
  public TileFlipValues? Flip { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public DocumentModel.Drawing.RectangleAlignmentValues? Alignment { get ; set; }
  
}
