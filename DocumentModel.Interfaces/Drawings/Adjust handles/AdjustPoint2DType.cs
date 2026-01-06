namespace DocumentModel.Drawings;

/// <summary>
/// Represents a two-dimensional adjustment point with X and Y coordinates, used for shape geometry manipulation.
/// </summary>
public interface AdjustPoint2DType
{
  /// <summary>
  /// Gets or sets the X-coordinate of the adjustment point.
  /// </summary>
  public string? X { get; set; }

  /// <summary>
  /// Gets or sets the Y-coordinate of the adjustment point.
  /// </summary>
  public string? Y { get; set; }
}