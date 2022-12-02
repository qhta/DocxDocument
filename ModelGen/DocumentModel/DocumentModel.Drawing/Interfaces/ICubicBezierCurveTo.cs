namespace DocumentModel.Drawing;

/// <summary>
/// Draw Cubic Bezier Curve To.
/// </summary>
public interface ICubicBezierCurveTo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAdjustPoint2DType>? Points { get ; set; }
  
}
