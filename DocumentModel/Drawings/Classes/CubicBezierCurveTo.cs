namespace DocumentModel.Drawings;

/// <summary>
///   Draw Cubic Bezier Curve To.
/// </summary>
public record CubicBezierCurveTo
{
  public Collection<AdjustPoint2DType>? Points { get; set; }
}