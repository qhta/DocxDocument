namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the Point2DType Class.
/// </summary>
public class Point2DType: ModelElement
{
  /// <summary>
  ///   X-IAxis Coordinate
  /// </summary>
  public Int64? X { get; set; }

  /// <summary>
  ///   Y-IAxis Coordinate
  /// </summary>
  public Int64? Y { get; set; }
}
