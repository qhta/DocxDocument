namespace DocumentModel.Drawings;

/// <summary>
///   Draw Quadratic Bezier Curve To.
/// </summary>
public class QuadraticBezierCurveTo: ModelElement
{
  public Collection<AdjustPoint2DType>? Points { get; set; }
}