namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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