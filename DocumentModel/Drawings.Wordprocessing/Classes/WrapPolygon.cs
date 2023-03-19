namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public class WrapPolygon: ModelElement
{
  /// <summary>
  ///   Wrapping Points Modified
  /// </summary>
  public Boolean? Edited { get; set; }

  /// <summary>
  ///   Wrapping Polygon Start.
  /// </summary>
  public Point2DType? StartPoint { get; set; }

  public Point2DType? LineTo { get; set; }
}