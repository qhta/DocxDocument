namespace DocumentModel.Drawings;

/// <summary>
/// Draw Quadratic Bezier Curve To.
/// </summary>
public interface QuadraticBezierCurveTo
{
  public Collection<DocumentModel.Drawings.AdjustPoint2DType>? Points { get ; set; }
  
}
