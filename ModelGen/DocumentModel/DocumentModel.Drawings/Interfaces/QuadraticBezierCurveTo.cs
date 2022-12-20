namespace DocumentModel.Drawings;

/// <summary>
/// Draw Quadratic Bezier Curve To.
/// </summary>
public partial interface QuadraticBezierCurveTo
{
  public Collection<DocumentModel.Drawings.AdjustPoint2DType>? Points { get; set; }
  
}
