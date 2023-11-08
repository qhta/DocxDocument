namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies to draw a cubic bezier curve along the specified points. To specify a cubic bezier curve there needs to be 3 points specified. The first two are control points used in the cubic bezier calculation and the last is the ending point for the curve. The coordinate system used for this kind of curve is the path coordinate system as this element is path specific.
/// </summary>
public partial class CubicBezierCurveTo: ModelElement<DXD.CubicBezierCurveTo>
{
  public CubicBezierCurveTo(): base(){ }
  
  public CubicBezierCurveTo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CubicBezierCurveTo(DXD.CubicBezierCurveTo openXmlElement): base(openXmlElement) { }
  
}
