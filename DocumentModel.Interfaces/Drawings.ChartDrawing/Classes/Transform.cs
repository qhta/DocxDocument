namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Graphic Frame Transform.
/// </summary>
public interface Transform: IModelElement
{
  /// <summary>
  ///   Rotation
  /// </summary>
  public Int32? Rotation { get; set; }
  /// <summary>
  ///   Horizontal Flip
  /// </summary>
  public bool? HorizontalFlip { get; set; }
  /// <summary>
  ///   Vertical Flip
  /// </summary>
  public bool? VerticalFlip { get; set; }
  /// <summary>
  ///   Offset.
  /// </summary>
  public Point2DType? Offset { get; set; }
  /// <summary>
  ///   Extents.
  /// </summary>
  public PositiveSize2DType? Extents { get; set; }
}