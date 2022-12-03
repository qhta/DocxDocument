namespace DocumentModel.Drawings;

/// <summary>
/// Draw Cubic Bezier Curve To.
/// </summary>
public interface CubicBezierCurveTo // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<AdjustPoint2DType>? Points { get ; set; }
  
}
