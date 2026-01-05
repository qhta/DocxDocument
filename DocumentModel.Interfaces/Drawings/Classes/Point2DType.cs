namespace DocumentModel.Drawings;

/// <summary>
///   Defines the Point2DType interface.
/// </summary>
public interface Point2DType:
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