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
  
  public QuadraticBezierCurveToImpl(): base() {}
  
  public QuadraticBezierCurveToImpl(DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public AdjustPoint2DType? Point
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
