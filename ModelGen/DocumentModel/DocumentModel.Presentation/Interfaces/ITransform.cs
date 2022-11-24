namespace DocumentModel.Presentation;

/// <summary>
/// 2D Transform for Graphic Frame.
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
  public IOffset? Offset { get ; set; }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public IExtents? Extents { get ; set; }
  
}
