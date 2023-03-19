namespace DocumentModel.Drawings;

/// <summary>
///   Draw Cubic Bezier Curve To.
/// </summary>
public class CubicBezierCurveTo: ModelElement
{
  public Collection<AdjustPoint2DType>? Points { get; set; }
}