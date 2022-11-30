namespace DocumentModel.Drawing;

/// <summary>
/// Draw Quadratic Bezier Curve To.
/// </summary>
public interface IQuadraticBezierCurveTo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IAdjustPoint2DType>? Points { get ; set; }
  
}
