namespace DocumentModel.Drawings;

/// <summary>
///   Represents a 2D point with X and Y coordinates.
/// </summary>
public class Point2DType: ModelElement
{
  /// <summary>
  ///   X-axis coordinate of the point.
  /// </summary>
  public Int64? X { get; set; }

  /// <summary>
  ///   Y-axis coordinate of the point.
  /// </summary>
  public Int64? Y { get; set; }
}