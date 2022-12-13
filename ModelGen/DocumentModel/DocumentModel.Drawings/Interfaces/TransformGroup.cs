namespace DocumentModel.Drawings;

/// <summary>
/// 2D Transform for Grouped Objects.
/// </summary>
public interface TransformGroup
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
  
  /// <summary>
  /// Child Offset.
  /// </summary>
  public DocumentModel.Drawings.Point2DType? ChildOffset { get ; set; }
  
  /// <summary>
  /// Child Extents.
  /// </summary>
  public DocumentModel.Drawings.PositiveSize2DType? ChildExtents { get ; set; }
  
}
