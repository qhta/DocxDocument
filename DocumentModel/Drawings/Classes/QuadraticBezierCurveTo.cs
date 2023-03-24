namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Draw Quadratic Bezier Curve To.
/// </summary>
public class QuadraticBezierCurveTo: ModelElement
{
  public Collection<AdjustPoint2DType>? Points { get; set; }
}