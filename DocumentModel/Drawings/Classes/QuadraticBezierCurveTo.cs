namespace DocumentModel.Drawings;

/// <summary>
///   Draw Quadratic Bezier Curve To.
/// </summary>
public record QuadraticBezierCurveTo
{
  public Collection<AdjustPoint2DType>? Points { get; set; }
}