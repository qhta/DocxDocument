namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes the transformation properties for a graphic frame in chart drawing, including rotation, flipping, offset, and extents for precise visual positioning and scaling.
/// </summary>
public interface Transform
{
  /// <summary>
  /// Rotation angle in degrees.
  /// </summary>
  public Int32? Rotation { get; set; }

  /// <summary>
  /// Indicates horizontal flip transformation.
  /// </summary>
  public bool? HorizontalFlip { get; set; }

  /// <summary>
  /// Indicates vertical flip transformation.
  /// </summary>
  public bool? VerticalFlip { get; set; }

  /// <summary>
  /// Offset point specifying the position of the graphic frame.
  /// </summary>
  public Point2DType? Offset { get; set; }

  /// <summary>
  /// Extents specifying the size of the graphic frame.
  /// </summary>
  public PositiveSize2DType? Extents { get; set; }
}