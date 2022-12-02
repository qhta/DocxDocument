namespace DocumentModel.Drawing;

/// <summary>
/// Graphic Frame Transform.
/// </summary>
public interface ITransform // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
}
