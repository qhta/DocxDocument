namespace DocumentModel.Drawings;

/// <summary>
/// Draw Quadratic Bezier Curve To.
/// </summary>
public class QuadraticBezierCurveToImpl: ModelElementImpl, QuadraticBezierCurveTo
{
  public DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<AdjustPoint2DType>? Points
  {
    get;
    set;
  }
  
}
