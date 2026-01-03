namespace DocumentModel.Drawings;

/// <summary>
///   Draw Cubic Bezier Curve To.
/// </summary>
public interface CubicBezierCurveTo: IModelElement
{
  public Collection<AdjustPoint2DType>? Points { get; set; }
}