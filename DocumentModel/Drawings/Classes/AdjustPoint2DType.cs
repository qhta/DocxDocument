namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the AdjustPoint2DType Class.
/// </summary>
public class AdjustPoint2DType: ModelElement
{
  /// <summary>
  ///   X-Coordinate
  /// </summary>
  public string? X { get; set; }

  /// <summary>
  ///   Y-Coordinate
  /// </summary>
  public string? Y { get; set; }
}