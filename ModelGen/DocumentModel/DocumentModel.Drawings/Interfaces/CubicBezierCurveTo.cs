namespace DocumentModel.Drawings;

/// <summary>
/// Draw Cubic Bezier Curve To.
/// </summary>
public interface CubicBezierCurveTo
{
  public Collection<DocumentModel.Drawings.AdjustPoint2DType>? Points { get ; set; }
  
}
