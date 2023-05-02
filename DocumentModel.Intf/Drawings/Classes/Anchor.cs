namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Anchor Point.
/// </summary>
public class Anchor: ModelElement
{
  /// <summary>
  ///   X-Coordinate in 3D
  /// </summary>
  public Int64? X { get; set; }

  /// <summary>
  ///   Y-Coordinate in 3D
  /// </summary>
  public Int64? Y { get; set; }

  /// <summary>
  ///   Z-Coordinate in 3D
  /// </summary>
  public Int64? Z { get; set; }
}