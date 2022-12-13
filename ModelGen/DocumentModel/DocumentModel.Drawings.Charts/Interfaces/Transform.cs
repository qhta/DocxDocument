namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Graphic Frame Transform.
/// </summary>
public interface Transform
{
  /// <summary>
  /// Rotation
  /// </summary>
  public Int32? Rotation { get ; set; }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  public Boolean? HorizontalFlip { get ; set; }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  public Boolean? VerticalFlip { get ; set; }
  
  /// <summary>
  /// Offset.
  /// </summary>
  public DocumentModel.Drawings.Point2DType? Offset { get ; set; }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public DocumentModel.Drawings.PositiveSize2DType? Extents { get ; set; }
  
}
