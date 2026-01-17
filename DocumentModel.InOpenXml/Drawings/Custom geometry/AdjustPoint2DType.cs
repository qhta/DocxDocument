namespace DocumentModel.Drawings;

/// <summary>
/// Represents a two-dimensional adjustment point with X and Y coordinates, used for shape geometry manipulation.
/// </summary>
public class AdjustPoint2DType: ModelElement<DXD.AdjustPoint2DType>
{
  /// <summary>
  /// X-coordinate of the adjustment point.
  /// </summary>
  public AdjustCoordinate? X { get; set; }

  /// <summary>
  /// Y-coordinate of the adjustment point.
  /// </summary>
  public AdjustCoordinate? Y { get; set; }
}