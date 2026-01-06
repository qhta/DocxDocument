namespace DocumentModel.Drawings;

/// <summary>
/// Represents a polar adjust handle, providing guides and limits for radial and angular adjustments of a shape.
/// </summary>
public interface AdjustHandlePolar
{
  /// <summary>
  /// Gets or sets the radial adjustment guide, which determines how the radial distance is adjusted.
  /// </summary>
  public string? RadialAdjustmentGuide { get; set; }

  /// <summary>
  /// Gets or sets the minimum allowed value for radial adjustment.
  /// </summary>
  public string? MinRadial { get; set; }

  /// <summary>
  /// Gets or sets the maximum allowed value for radial adjustment.
  /// </summary>
  public string? MaxRadial { get; set; }

  /// <summary>
  /// Gets or sets the angle adjustment guide, which determines how the angle is adjusted.
  /// </summary>
  public string? AngleAdjustmentGuide { get; set; }

  /// <summary>
  /// Gets or sets the minimum allowed value for angle adjustment.
  /// </summary>
  public string? MinAngle { get; set; }

  /// <summary>
  /// Gets or sets the maximum allowed value for angle adjustment.
  /// </summary>
  public string? MaxAngle { get; set; }

  /// <summary>
  /// Gets or sets the position of the adjust handle as a two-dimensional coordinate.
  /// </summary>
  public AdjustPoint2DType? Position { get; set; }
}