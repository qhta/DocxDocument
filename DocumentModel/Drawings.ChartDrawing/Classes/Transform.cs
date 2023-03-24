namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Graphic Frame Transform.
/// </summary>
public class Transform: ModelElement
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
}