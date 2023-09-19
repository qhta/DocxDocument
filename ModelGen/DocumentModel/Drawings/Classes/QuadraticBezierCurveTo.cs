namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies to draw a quadratic bezier curve along the specified points. To specify a quadratic bezier curve there needs to be 2 points specified. The first is a control point used in the quadratic bezier calculation and the last is the ending point for the curve. The coordinate system used for this type of curve is the path coordinate system as this element is path specific.
/// </summary>
public partial class QuadraticBezierCurveTo
{
  public DocumentModel.ElementCollection<DocumentModel.Drawings.AdjustPoint2DType>? Items { get; set; }
  
}
