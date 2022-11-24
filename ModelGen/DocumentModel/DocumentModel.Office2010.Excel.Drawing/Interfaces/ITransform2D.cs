namespace DocumentModel.Office2010.Excel.Drawing;

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
  public IOffset? Offset { get ; set; }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public IExtents? Extents { get ; set; }
  
}
