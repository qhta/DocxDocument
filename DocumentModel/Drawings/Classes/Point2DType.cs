namespace DocumentModel.Drawings;

/// <summary>
///   Defines the Point2DType Class.
/// </summary>
public class Point2DType: ModelElement
{
  /// <summary>
  ///   X-Axis Coordinate
  /// </summary>
  public Int64? X { get; set; }

  /// <summary>
  ///   Y-Axis Coordinate
  /// </summary>
  public Int64? Y { get; set; }
}