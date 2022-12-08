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
  
  public Collection<AdjustPoint2DType>? Points
  {
    get;
    set;
  }
  
}
