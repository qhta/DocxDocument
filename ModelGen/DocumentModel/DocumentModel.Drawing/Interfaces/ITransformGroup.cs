namespace DocumentModel.Drawing;

/// <summary>
/// 2D Transform for Grouped Objects.
/// </summary>
public interface ITransformGroup // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IPoint2DType? Offset { get ; set; }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public IPositiveSize2DType? Extents { get ; set; }
  
  /// <summary>
  /// Child Offset.
  /// </summary>
  public IPoint2DType? ChildOffset { get ; set; }
  
  /// <summary>
  /// Child Extents.
  /// </summary>
  public IPositiveSize2DType? ChildExtents { get ; set; }
  
}
