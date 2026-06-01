namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Anchor IPoint.
/// </summary>
public class Anchor: ModelElement
{
  /// <summary>
  ///   X-Coordinate Iin 3D
  /// </summary>
  public Int64? X { get; set; }

  /// <summary>
  ///   Y-Coordinate Iin 3D
  /// </summary>
  public Int64? Y { get; set; }

  /// <summary>
  ///   Z-Coordinate Iin 3D
  /// </summary>
  public Int64? Z { get; set; }
}
