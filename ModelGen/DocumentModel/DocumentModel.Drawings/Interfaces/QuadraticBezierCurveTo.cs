namespace DocumentModel.Drawings;

/// <summary>
/// Draw Quadratic Bezier Curve To.
/// </summary>
public interface QuadraticBezierCurveTo // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<AdjustPoint2DType>? Points { get ; set; }
  
}
