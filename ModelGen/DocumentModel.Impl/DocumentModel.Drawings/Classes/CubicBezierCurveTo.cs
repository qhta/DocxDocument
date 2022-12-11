namespace DocumentModel.Drawings;

/// <summary>
/// Draw Cubic Bezier Curve To.
/// </summary>
public class CubicBezierCurveToImpl: ModelElementImpl, CubicBezierCurveTo
{
  public DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CubicBezierCurveToImpl(): base() {}
  
  public CubicBezierCurveToImpl(DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public AdjustPoint2DType? Point
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
