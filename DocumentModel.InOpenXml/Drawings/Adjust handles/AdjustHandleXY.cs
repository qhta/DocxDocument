namespace DocumentModel.Drawings;

/// <summary>
/// Represents an XY adjust handle, providing guides and limits for horizontal and vertical adjustments of a shape.
/// </summary>
public class AdjustHandleXY: ModelElement
{
  /// <summary>
  /// Horizontal adjustment guide, which determines how the X coordinate is adjusted.
  /// </summary>
  public string? XAdjustmentGuide { get; set; }

  /// <summary>
  /// Minimum allowed value for horizontal adjustment.
  /// </summary>
  public string? MinX { get; set; }

  /// <summary>
  /// Maximum allowed value for horizontal adjustment.
  /// </summary>
  public string? MaxX { get; set; }

  /// <summary>
  /// Vertical adjustment guide, which determines how the Y coordinate is adjusted.
  /// </summary>
  public string? YAdjustmentGuide { get; set; }

  /// <summary>
  /// Minimum allowed value for vertical adjustment.
  /// </summary>
  public string? MinY { get; set; }

  /// <summary>
  /// Maximum allowed value for vertical adjustment.
  /// </summary>
  public string? MaxY { get; set; }

  /// <summary>
  /// Position of the adjust handle as a two-dimensional point.
  /// </summary>
  public AdjustPoint2DType? Position { get; set; }
}