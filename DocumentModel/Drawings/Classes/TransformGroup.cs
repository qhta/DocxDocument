namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  public Boolean? HorizontalFlip { get; set; }

  /// <summary>
  ///   Vertical Flip
  /// </summary>
  public Boolean? VerticalFlip { get; set; }

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