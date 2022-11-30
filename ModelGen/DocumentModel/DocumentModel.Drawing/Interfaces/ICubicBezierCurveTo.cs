namespace DocumentModel.Drawing;

/// <summary>
/// Draw Cubic Bezier Curve To.
/// </summary>
public interface ICubicBezierCurveTo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IAdjustPoint2DType>? Points { get ; set; }
  
}
