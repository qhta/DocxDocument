namespace DocumentModel.Drawings;

/// <summary>
/// Represents an XY adjust handle, providing guides and limits for horizontal and vertical adjustments of a shape.
/// </summary>
public interface AdjustHandleXY
{
  /// <summary>
  /// Gets or sets the horizontal adjustment guide, which determines how the X coordinate is adjusted.
  /// </summary>
  public string? XAdjustmentGuide { get; set; }

  /// <summary>
  /// Gets or sets the minimum allowed value for horizontal adjustment.
  /// </summary>
  public string? MinX { get; set; }

  /// <summary>
  /// Gets or sets the maximum allowed value for horizontal adjustment.
  /// </summary>
  public string? MaxX { get; set; }

  /// <summary>
  /// Gets or sets the vertical adjustment guide, which determines how the Y coordinate is adjusted.
  /// </summary>
  public string? YAdjustmentGuide { get; set; }

  /// <summary>
  /// Gets or sets the minimum allowed value for vertical adjustment.
  /// </summary>
  public string? MinY { get; set; }

  /// <summary>
  /// Gets or sets the maximum allowed value for vertical adjustment.
  /// </summary>
  public string? MaxY { get; set; }

  /// <summary>
  /// Gets or sets the position of the adjust handle as a two-dimensional point.
  /// </summary>
  public AdjustPoint2DType? Position { get; set; }
}