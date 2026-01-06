namespace DocumentModel.Drawings;

/// <summary>
/// Represents a two-dimensional adjustment point with X and Y coordinates, used for shape geometry manipulation.
/// </summary>
public interface AdjustPoint2DType
{
  /// <summary>
  /// X-coordinate of the adjustment point.
  /// </summary>
  public string? X { get; set; }

  /// <summary>
  /// Y-coordinate of the adjustment point.
  /// </summary>
  public string? Y { get; set; }
}