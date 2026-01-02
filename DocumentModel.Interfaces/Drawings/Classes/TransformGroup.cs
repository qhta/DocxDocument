namespace DocumentModel.Drawings;

/// <summary>
///   2D Transform for Grouped Objects.
/// </summary>
public class TransformGroup: ModelElement
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
  /// <summary>
  ///   Child Offset.
  /// </summary>
  public Point2DType? ChildOffset { get; set; }
  /// <summary>
  ///   Child Extents.
  /// </summary>
  public PositiveSize2DType? ChildExtents { get; set; }
}