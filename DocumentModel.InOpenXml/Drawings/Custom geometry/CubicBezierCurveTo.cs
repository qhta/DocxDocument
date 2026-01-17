namespace DocumentModel.Drawings;

/// <summary>
///   Represents a command to draw a cubic Bézier curve in a path geometry.
///   The curve is defined by a collection of adjustment points.
/// </summary>
public class CubicBezierCurveTo: ModelElement<DXD.CubicBezierCurveTo>
{
  /// <summary>
  ///   Collection of points that define the cubic Bézier curve.
  ///   Typically includes two control points and an endpoint.
  /// </summary>
  public AdjustPoints? Points { get; set; }
}