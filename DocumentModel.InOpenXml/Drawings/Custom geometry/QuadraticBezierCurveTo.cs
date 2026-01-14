namespace DocumentModel.Drawings;

/// <summary>
///   Represents a command to draw a quadratic Bézier curve in a path geometry.
///   The curve is defined by a collection of adjustment points.
/// </summary>
public class QuadraticBezierCurveTo: ModelElement
{
  /// <summary>
  ///   Collection of points that define the quadratic Bézier curve.
  ///   Typically includes a control point and an endpoint.
  /// </summary>
  public AdjustPoints? Points { get; set; }
}