namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public record WrapPolygon
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