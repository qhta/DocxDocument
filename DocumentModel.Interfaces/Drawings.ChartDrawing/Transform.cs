namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes transformation settings for a graphic frame in chart drawings, including rotation, flipping, offset, and size extents.
/// </summary>
public interface Transform
{
  /// <summary>
  /// Rotation angle applied to the graphic frame.
  /// </summary>
  public Int32? Rotation { get; set; }

  /// <summary>
  /// Indicates whether the graphic frame is flipped horizontally.
  /// </summary>
  public bool? HorizontalFlip { get; set; }

  /// <summary>
  /// Indicates whether the graphic frame is flipped vertically.
  /// </summary>
  public bool? VerticalFlip { get; set; }

  /// <summary>
  /// Offset position for the graphic frame within the drawing canvas.
  /// </summary>
  public Point2DType? Offset { get; set; }

  /// <summary>
  /// Size extents specifying the width and height of the graphic frame.
  /// </summary>
  public PositiveSize2DType? Extents { get; set; }
}