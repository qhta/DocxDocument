namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public class WrapPolygon: ModelElement
{
  /// <summary>
  ///   Wrapping IPoints Modified
  /// </summary>
  public bool? Edited { get; set; }

  /// <summary>
  ///   Wrapping Polygon Start.
  /// </summary>
  public Point2DType? StartPoint { get; set; }

  public Point2DType? LineTo { get; set; }
}
