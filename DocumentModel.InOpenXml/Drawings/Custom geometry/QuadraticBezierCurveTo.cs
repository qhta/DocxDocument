namespace DocumentModel.Drawings;
/// <summary>
///   Represents a command to draw a quadratic B�zier curve in a path geometry.
///   The curve is defined by a collection of adjustment points.
/// </summary>
[OpenXmlType(typeof(DXD.QuadraticBezierCurveTo))]
public partial class QuadraticBezierCurveTo : ModelElement<DXD.QuadraticBezierCurveTo>
{
 /// <summary>
 ///   Collection of points that define the quadratic B�zier curve.
 ///   Typically includes a control point and an endpoint.
 /// </summary>
 [OpenXmlElement(typeof(DXD.QuadraticBezierCurveTo))]
 public AdjustPoints? Points { get => _Points; set => UpdateField(ref _Points, value, nameof(Points)); }

 private AdjustPoints? _Points;
}