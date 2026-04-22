namespace DocumentModel.Drawings;
/// <summary>
///   Represents a command to draw a cubic B�zier curve in a path geometry.
///   The curve is defined by a collection of adjustment points.
/// </summary>
[OpenXmlType(typeof(DXD.CubicBezierCurveTo))]
[XmlRoot("CubicBezierCurveTo", Namespace = "DocumentModel.Drawings")]
public partial class CubicBezierCurveTo : ModelElement<DXD.CubicBezierCurveTo>
{
 /// <summary>
 ///   Collection of points that define the cubic B�zier curve.
 ///   Typically includes two control points and an endpoint.
 /// </summary>
 public AdjustPoints? Points { get => _Points; set => UpdateField(ref _Points, value, nameof(Points)); }
 private AdjustPoints? _Points;
}