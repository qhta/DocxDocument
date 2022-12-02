namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public interface ITransform2D // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.IPoint2DType? Offset { get ; set; }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public DocumentModel.Drawing.IPositiveSize2DType? Extents { get ; set; }
  
}
