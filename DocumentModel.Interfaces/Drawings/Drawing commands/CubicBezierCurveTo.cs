namespace DocumentModel.Drawings;

/// <summary>
///   Represents a command to draw a cubic Bézier curve in a path geometry.
/// </summary>
public interface CubicBezierCurveTo
{
  public Collection<AdjustPoint2DType>? Points { get; set; }
}